using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace SirKato.XrmToolBox.IconGallery
{
    public partial class IconGalleryControl : PluginControlBase
    {
        private Settings mySettings;
        private ImageList imageList;
        private List<WebResource> resources;
        private List<WebResource> filteredResources;
        private Image toBigImage;
        private Image errorImage;

        public Image ToBigImage
        {
            get
            {
                if (toBigImage == null)
                {
                    byte[] bytes = Convert.FromBase64String(mySettings.FileToBigImage);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        toBigImage = Image.FromStream(ms);
                    }
                }

                return toBigImage;
            }
        }

        public Image ErrorImage
        {
            get
            {
                if (errorImage == null)
                {
                    byte[] bytes = Convert.FromBase64String(mySettings.ErrorImage);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        errorImage = Image.FromStream(ms);
                    }
                }

                return errorImage;
            }
        }

        public IconGalleryControl()
        {
            InitializeComponent();
            resources = new List<WebResource>();
            filteredResources = new List<WebResource>();
            imageList = new ImageList();

            lvGallery.LargeImageList = imageList;
            lvGallery.VirtualMode = true;
            lvGallery.VirtualListSize = 0;
            lvGallery.MultiSelect = false;

            lvGallery.RetrieveVirtualItem += LvGallery_RetrieveVirtualItem;
            Disposed += IconGalleryControl_Disposed;
        }

        private void LvGallery_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex < filteredResources.Count)
            {
                var res = filteredResources[e.ItemIndex];
                var imageIndex = imageList.Images.IndexOfKey(res.Id.ToString());

                if (imageIndex > -1)
                {
                    e.Item = new ListViewItem { ImageIndex = imageIndex, Text = res.DisplayName };
                }
                else
                {
                    try
                    {
                        var image = GetImageFromWebResource(res);
                        if (image != null)
                        {
                            imageList.Images.Add(res.Id.ToString(), image);
                        }
                    }
                    catch
                    {
                        imageList.Images.Add(res.Id.ToString(), ErrorImage);
                    }


                    e.Item = new ListViewItem { ImageIndex = imageList.Images.Count - 1, Text = res.DisplayName };
                }
            }
            else
            {
                e.Item = new ListViewItem();
            }
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();
                mySettings.ImageSize = Settings.DEFAULT_IMAGE_SIZE;
                mySettings.ErrorImage = Settings.DEFAULT_ERROR_IMAGE_BASE64;
                mySettings.FileToBigImage = Settings.DEFAULT_TO_BIG_IMAGE_BASE64;

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }

            ApplySettings(mySettings);
        }

        private void ApplySettings(Settings settings)
        {
            imageList.ImageSize = new Size(settings.ImageSize, settings.ImageSize);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void OnLoadClicked(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            ExecuteMethod(GetImageResources);
        }

        private void GetImageResources()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting images",
                Work = WorkOnGetImageResources,
                PostWorkCallBack = PostWorkGetImageResources,
            });
        }

        private void WorkOnGetImageResources(BackgroundWorker worker, DoWorkEventArgs args)
        {
            List<WebResource> images = new List<WebResource>();
            List<Entity> entities = RetrieveImageWebresources();

            foreach (var entity in entities)
            {
                images.Add(entity.ToEntity<WebResource>());
                var webResource = entity.ToEntity<WebResource>();
            }

            args.Result = images;
        }

        private void PostWorkGetImageResources(RunWorkerCompletedEventArgs args)
        {
            var result = args.Result as List<WebResource>;

            if (result != null)
            {
                resources = result;
                filteredResources = result;
                lvGallery.VirtualListSize = resources.Count;
                btnApplyFilter.Text = $"Filter {resources.Count} images";
            }
        }

        private List<Entity> RetrieveImageWebresources()
        {
            List<Entity> entities = new List<Entity>();
            EntityCollection result = null;
            int page = 1;

            do
            {
                var query = new QueryExpression("webresource");
                query.ColumnSet.AddColumns("name", "webresourcetype", "displayname", "content");

                var filter = new FilterExpression();
                query.Criteria.AddFilter(filter);

                filter.FilterOperator = LogicalOperator.Or;
                filter.AddCondition("webresourcetype", ConditionOperator.Equal, (int)WebResource_WebResourceType.PNGFormat);
                filter.AddCondition("webresourcetype", ConditionOperator.Equal, (int)WebResource_WebResourceType.JPGFormat);
                filter.AddCondition("webresourcetype", ConditionOperator.Equal, (int)WebResource_WebResourceType.GIFFormat);
                filter.AddCondition("webresourcetype", ConditionOperator.Equal, (int)WebResource_WebResourceType.Vektorformat__SVG_);
                filter.AddCondition("webresourcetype", ConditionOperator.Equal, (int)WebResource_WebResourceType.ICOFormat);

                if (result != null && result.PagingCookie != null)
                {
                    query.PageInfo = new PagingInfo
                    {
                        PagingCookie = result.PagingCookie,
                        PageNumber = page
                    };
                }

                result = Service.RetrieveMultiple(query);
                entities.AddRange(result.Entities);

            } while (result.MoreRecords);

            return entities;
        }

        private Image GetImageFromWebResource(WebResource webResource)
        {
            if (webResource.Content.Length > 500000)
            {
                return ToBigImage;
            } 

            byte[] bytes = Convert.FromBase64String(webResource.Content);

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                if (webResource.Name != null && webResource.Name.ToLower().EndsWith(".svg") || webResource.WebResourceType == WebResource_WebResourceType.Vektorformat__SVG_)
                {
                    var svg = SvgDocument.Open<SvgDocument>(ms);
                    var bitmap = svg.Draw(mySettings.ImageSize, mySettings.ImageSize);
                    return bitmap;
                }
                else if ((webResource.Name != null && webResource.Name.ToLower().EndsWith(".ico")) || webResource.WebResourceType == WebResource_WebResourceType.ICOFormat)
                {
                    var icon = new Icon(ms);
                    var bitmap = icon.ToBitmap();
                    icon.Dispose();
                    icon = null;

                    return bitmap;
                }
                else if (!webResource.Name.EndsWith(".ttf") && !webResource.Name.EndsWith(".woff"))
                {
                    return Image.FromStream(ms);
                }
            }

            return null;
        }

        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private WebResource_WebResourceType ConvertType(string type)
        {
            switch (type)
            {
                case "PNG":
                    return WebResource_WebResourceType.PNGFormat;
                case "JPEG":
                    return WebResource_WebResourceType.JPGFormat;
                case "GIF":
                    return WebResource_WebResourceType.GIFFormat;
                case "SVG":
                    return WebResource_WebResourceType.Vektorformat__SVG_;
                case "ICO":
                    return WebResource_WebResourceType.ICOFormat;
                default:
                    return WebResource_WebResourceType.PNGFormat;
            }
        }

        private WebResource GetSelectedResource()
        {
            if (lvGallery.SelectedIndices.Count > 0)
            {
                return filteredResources[lvGallery.SelectedIndices[0]];
            }

            ShowInfoNotification("Select an image first.", null);
            return null;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string text = tBoxTextFilter.Text;
            string type = cbTypeFilter.SelectedItem.ToString();

            filteredResources = resources;
            btnApplyFilter.Text = $"Filter {resources.Count} images";

            if (!string.IsNullOrEmpty(text))
            {
                filteredResources = filteredResources.Where(x => x.DisplayName != null && x.DisplayName.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1).ToList();
            }

            if (type != "All")
            {
                var typeVal = ConvertType(type);
                filteredResources = filteredResources.Where(x => x.WebResourceType == typeVal).ToList();
            }

            lvGallery.VirtualListSize = filteredResources.Count;
            btnApplyFilter.Text = $"Filtered down to {filteredResources.Count} images";
        }

        private void btnCopyDisplayName_Click(object sender, EventArgs e)
        {
            var resource = GetSelectedResource();

            if (resource != null)
            {
                Clipboard.SetText(resource.DisplayName);
            }
        }

        private void btnCopyGuid_Click(object sender, EventArgs e)
        {
            var resource = GetSelectedResource();

            if (resource != null)
            {
                Clipboard.SetText(resource.Id.ToString());
            }
        }

        private void btnCopyName_Click(object sender, EventArgs e)
        {
            var resource = GetSelectedResource();

            if (resource != null)
            {
                Clipboard.SetText(resource.Name);
            }
        }

        private void tBoxTextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                btnApplyFilter_Click(null, null);
                e.Handled = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            var changedSettings = settingsForm.EditSettings(mySettings);

            if (changedSettings != null)
            {
                ShowInfoNotification("Changes to settings are applied the next time you use the Icon Gallery.", null);
                mySettings = changedSettings;
                SettingsManager.Instance.Save(GetType(), mySettings);
            }
        }

        private void IconGalleryControl_Disposed(object sender, EventArgs e)
        {
            if (lvGallery != null)
            {
                lvGallery.Clear();
                lvGallery.RetrieveVirtualItem -= LvGallery_RetrieveVirtualItem;
                lvGallery.Dispose();
                lvGallery = null;
            }

            if (imageList != null)
            {
                imageList.Images.Clear();
                imageList.Dispose();
                imageList = null;
            }

            if (resources != null)
            {
                resources.Clear();
                resources = null;
            }

            if (filteredResources != null)
            {
                filteredResources.Clear();
                filteredResources = null;
            }

            if (mySettings != null)
            {
                mySettings = null;
            }

            if (errorImage != null)
            {
                errorImage.Dispose();
                errorImage = null;
            }

            if (toBigImage != null)
            {
                toBigImage.Dispose();
                toBigImage = null;
            }

            if (Events != null)
            {
                Events.Dispose();
            }
        }
    }
}