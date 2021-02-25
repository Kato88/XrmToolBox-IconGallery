namespace SirKato.XrmToolBox.IconGallery
{
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum WebResource_WebResourceType
	{

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Daten (XML)", 3)]
		Daten__XML_ = 4,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("GIF-Format", 6)]
		GIFFormat = 7,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("ICO-Format", 9)]
		ICOFormat = 10,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("JPG-Format", 5)]
		JPGFormat = 6,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("PNG-Format", 4)]
		PNGFormat = 5,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Silverlight (XAP)", 7)]
		Silverlight__XAP_ = 8,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Skript (JScript)", 2)]
		Skript__JScript_ = 3,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Stylesheet (CSS)", 1)]
		Stylesheet__CSS_ = 2,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Stylesheet (XSL)", 8)]
		Stylesheet__XSL_ = 9,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Vektorformat (SVG)", 10)]
		Vektorformat__SVG_ = 11,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Webseite (HTML)", 0)]
		Webseite__HTML_ = 1,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Zeichenfolge (RESX)", 11)]
		Zeichenfolge__RESX_ = 12,
	}

	/// <summary>
	/// Daten, die bei der Webentwicklung verwendeten Dateien entsprechen. Von Webressourcen werden clientseitige Komponenten zur Verfügung gestellt, die zur Bereitstellung benutzerdefinierter Benutzeroberflächenelemente verwendet werden.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("webresource")]
	public partial class WebResource : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public WebResource() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "webresource";
		
		public const string EntitySchemaName = "WebResource";
		
		public const string PrimaryIdAttribute = "webresourceid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "webresources";
		
		public const string EntitySetName = "webresourceset";
		
		public const int EntityTypeCode = 9333;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Informationen, mit denen angegeben wird, ob die Komponente gelöscht werden kann.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbedeleted")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty CanBeDeleted
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("canbedeleted");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CanBeDeleted");
				this.SetAttributeValue("canbedeleted", value);
				this.OnPropertyChanged("CanBeDeleted");
			}
		}

		
		/// <summary>
		/// Bytes der Webressource im Base64-Format.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
		public string Content
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("content");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Content");
				this.SetAttributeValue("content", value);
				this.OnPropertyChanged("Content");
			}
		}
		
		/// <summary>
		/// JSON-Darstellung des Inhalts der Ressource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contentjson")]
		public string ContentJson
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("contentjson");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ContentJson");
				this.SetAttributeValue("contentjson", value);
				this.OnPropertyChanged("ContentJson");
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner des Benutzers, der die Webressource erstellt hat.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Datum und Uhrzeit der Erstellung der Webressource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner des stellvertretenden Benutzers, der die Webressource erstellt hat.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Nur zur internen Verwendung
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependencyxml")]
		public string DependencyXml
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("dependencyxml");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DependencyXml");
				this.SetAttributeValue("dependencyxml", value);
				this.OnPropertyChanged("DependencyXml");
			}
		}
		
		/// <summary>
		/// Beschreibung der Webressource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Anzeigename der Webressource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayname")]
		public string DisplayName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("displayname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DisplayName");
				this.SetAttributeValue("displayname", value);
				this.OnPropertyChanged("DisplayName");
			}
		}
		
		/// <summary>
		/// Version, in der das Formular eingeführt wird.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Gibt an, ob diese Webressource für den mobilen Client im Offlinemodus verfügbar ist.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isavailableformobileoffline")]
		public System.Nullable<bool> IsAvailableForMobileOffline
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isavailableformobileoffline");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsAvailableForMobileOffline");
				this.SetAttributeValue("isavailableformobileoffline", value);
				this.OnPropertyChanged("IsAvailableForMobileOffline");
			}
		}
		
		/// <summary>
		/// Informationen, mit denen angegeben wird, ob die Komponente angepasst werden kann.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsCustomizable");
				this.SetAttributeValue("iscustomizable", value);
				this.OnPropertyChanged("IsCustomizable");
			}
		}
		
		/// <summary>
		/// Gibt an, ob diese Webressource für den mobilen Client geeignet ist.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isenabledformobileclient")]
		public System.Nullable<bool> IsEnabledForMobileClient
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isenabledformobileclient");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsEnabledForMobileClient");
				this.SetAttributeValue("isenabledformobileclient", value);
				this.OnPropertyChanged("IsEnabledForMobileClient");
			}
		}
		
		/// <summary>
		/// Informationen, mit denen angegeben wird, ob die Komponente ausgeblendet werden soll.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishidden")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsHidden
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsHidden");
				this.SetAttributeValue("ishidden", value);
				this.OnPropertyChanged("IsHidden");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Sprache der Webressource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("languagecode")]
		public System.Nullable<int> LanguageCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("languagecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LanguageCode");
				this.SetAttributeValue("languagecode", value);
				this.OnPropertyChanged("LanguageCode");
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner des Benutzers, der die Webressource zuletzt geändert hat.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Datum und Uhrzeit der letzten Änderung der Webressource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner des stellvertretenden Benutzers, der die Webressource geändert hat.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Name der Webressource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner der Organisation, der die Webressource zugeordnet ist.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Nur zur internen Verwendung.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Versionsnummer der Silverlight-Laufzeit, die von einer Silverlight-Webressource erfordert wird.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("silverlightversion")]
		public string SilverlightVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("silverlightversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SilverlightVersion");
				this.SetAttributeValue("silverlightversion", value);
				this.OnPropertyChanged("SilverlightVersion");
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner der zugeordneten Lösung.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner der Webressource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
		public System.Nullable<System.Guid> WebResourceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("webresourceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WebResourceId");
				this.SetAttributeValue("webresourceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("WebResourceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.WebResourceId = value;
			}
		}
		
		/// <summary>
		/// Nur zur internen Verwendung.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceidunique")]
		public System.Nullable<System.Guid> WebResourceIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("webresourceidunique");
			}
		}
		
		/// <summary>
		/// Dropdownliste zur Auswahl der Webressource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourcetype")]
		public virtual WebResource_WebResourceType? WebResourceType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((WebResource_WebResourceType?)(EntityOptionSetEnum.GetEnum(this, "webresourcetype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WebResourceType");
				this.SetAttributeValue("webresourcetype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("WebResourceType");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public WebResource(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["webresourceid"] = base.Id;
                        break;
                    case "webresourceid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}

	internal sealed class EntityOptionSetEnum
	{
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public static System.Nullable<int> GetEnum(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
		{
			if (entity.Attributes.ContainsKey(attributeLogicalName))
			{
				Microsoft.Xrm.Sdk.OptionSetValue value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>(attributeLogicalName);
				if (value != null)
				{
					return value.Value;
				}
			}
			return null;
		}
	}
	
	/// <summary>
	/// Attribute to handle storing the OptionSet's Metadata.
	/// </summary>
	[System.AttributeUsageAttribute(System.AttributeTargets.Field)]
	public sealed class OptionSetMetadataAttribute : System.Attribute
	{
		
		/// <summary>
		/// Color of the OptionSetValue.
		/// </summary>
		public string Color { get; set; }
		
		/// <summary>
		/// Description of the OptionSetValue.
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// Display order index of the OptionSetValue.
		/// </summary>
		public int DisplayIndex { get; set; }
		
		/// <summary>
		/// External value of the OptionSetValue.
		/// </summary>
		public string ExternalValue { get; set; }
		
		/// <summary>
		/// Name of the OptionSetValue.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Initializes a new instance of the <see cref="OptionSetMetadataAttribute"/> class.
		/// </summary>
		/// <param name="name">Name of the value.</param>
		/// <param name="displayIndex">Display order index of the value.</param>
		/// <param name="color">Color of the value.</param>
		/// <param name="description">Description of the value.</param>
		/// <param name="externalValue">External value of the value.</param>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OptionSetMetadataAttribute(string name, int displayIndex, string color = null, string description = null, string externalValue = null)
		{
			this.Color = color;
			this.Description = description;
			this.ExternalValue = externalValue;
			this.DisplayIndex = displayIndex;
			this.Name = name;
		}
	}
	
	/// <summary>
	/// Extension class to handle retrieving of OptionSetMetadataAttribute.
	/// </summary>
	public static class OptionSetExtension
	{
		
		/// <summary>
		/// Returns the OptionSetMetadataAttribute for the given enum value
		/// </summary>
		/// <typeparam name="T">OptionSet Enum Type</typeparam>
		/// <param name="value">Enum Value with OptionSetMetadataAttribute</param>
		[System.Diagnostics.DebuggerNonUserCode()]
		public static OptionSetMetadataAttribute GetMetadata<T>(this T value)
			where T :  struct, System.IConvertible
		{
			System.Type enumType = typeof(T);
			if (!enumType.IsEnum)
			{
				throw new System.ArgumentException("T must be an enum!");
			}
			System.Reflection.MemberInfo[] members = enumType.GetMember(value.ToString());
			for (int i = 0; (i < members.Length); i++
			)
			{
				System.Attribute attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(members[i], typeof(OptionSetMetadataAttribute));
				if (attribute != null)
				{
					return ((OptionSetMetadataAttribute)(attribute));
				}
			}
			throw new System.ArgumentException("T must be an enum adorned with an OptionSetMetadataAttribute!");
		}
	}
}
