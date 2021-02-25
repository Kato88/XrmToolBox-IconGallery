using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace SirKato.XrmToolBox.IconGallery
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Icon Gallery"),
        ExportMetadata("Description", "View all available images and icons in a gallery."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAARpJREFUeNrsldENgjAQhgsygCPw4jsbiJPACsYBxGc1zOAITmDZAB+NLx0BBxC84pHU80gUE/pgLzkbz/710v/j8Hx/kgohEmEnDgF8hJCxpQYKX1gO6w1oC6TF/5cdA3OjWGo4IHNzZ13fFwCsrkUmRLgmA/WqD8JjD5gRqRe4DtY7CD3wJUQbuqi0N8Qr7aGEvbo2NT3EdbCeY0DhIdRDiYeGpEYZUKvZ8k2/vexYfYAb1+RQRWo6MqSdg2uw3kEY4HVJMkiqnglZku+KsPC1vmugYCAsmAPOkDemgRf9/pp/rodHI4NsjDxBxqTWtH49fzPr2c96B6FtCK2PYgeha4CDcMxoR3HKvDrHig03B0a9AeHi7+MhwABZFKSNbIS4NQAAAABJRU5ErkJggg=="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAYAAACOEfKtAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAdxJREFUeNrsnMFNwzAUQE1ggIzgG9eMkE5CV6gEZ3IHqSuESRI2yJWbR+gCTbFFLL6KBN9OoUV5TyopUr789ahj/59QY2AWV+FHUVw3/vCIjiRW47jvCzzMA4EIRCACEQgIRCACl12JWH+w6Ehi8JXIDg0nmce+Fvavg+LViJhaGXM4GqvLGKv7xfy6zPxqroEsIghEIAIBgQhEIALhj2ph5+s/N8WU/lBpBgl3r8ROP8SUiWPlxGjz2/mYISM/amG4oCkcCuNacX4fp+M07dfKKSyL/LXyciHHSo55uL3X5uee3p7bjPzacLm4mX4J8rRPJsTrmU2IacT7O+UfS46VE6PNL5zfZuQX4hyrMNsYBCIQgYBABCJwmcSNtBMb0G937bIIV8Z8KcKV57mZMdr8hsz8aCScsha2hnZWan6f7SyeTMjKr2YRYRVGIAIRCAhEIAIRCACwRGI3Zm0+bij/xMs47lvRtdhqBvExK1Gsb5VdEjlWTow2v9BV2WTktwldnNhQtUZ3N/5VvC+N/mkBSZUxVnWB+ZWswmxjEIhABAICEYhAKhFruC+cmh//5nCOTyAcfQJjLRyaCXx/YBqhQcL3B7IKI/B/E6+BPSqScSgAAAAAAIDz8C7AAOM/OrsHm3fRAAAAAElFTkSuQmCC"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class IconGalleryPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new IconGalleryControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public IconGalleryPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}