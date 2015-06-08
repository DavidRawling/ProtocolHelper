//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProtocolHandler
{
    
    
    /// <summary>
    /// The AppConfiguration Configuration Section.
    /// </summary>
    public partial class AppConfiguration : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the AppConfiguration Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string AppConfigurationSectionName = "appConfiguration";
        
        /// <summary>
        /// The XML path of the AppConfiguration Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string AppConfigurationSectionPath = "appConfiguration";
        
        /// <summary>
        /// Gets the AppConfiguration instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public static global::ProtocolHandler.AppConfiguration Instance
        {
            get
            {
                return ((global::ProtocolHandler.AppConfiguration)(global::System.Configuration.ConfigurationManager.GetSection(global::ProtocolHandler.AppConfiguration.AppConfigurationSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ProtocolHandler.AppConfiguration.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::ProtocolHandler.AppConfiguration.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Handlers Property
        /// <summary>
        /// The XML name of the <see cref="Handlers"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string HandlersPropertyName = "handlers";
        
        /// <summary>
        /// Gets or sets the Handlers.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Handlers.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ProtocolHandler.AppConfiguration.HandlersPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::ProtocolHandler.HandlerSet Handlers
        {
            get
            {
                return ((global::ProtocolHandler.HandlerSet)(base[global::ProtocolHandler.AppConfiguration.HandlersPropertyName]));
            }
            set
            {
                base[global::ProtocolHandler.AppConfiguration.HandlersPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace ProtocolHandler
{
    
    
    /// <summary>
    /// The Handler Configuration Element.
    /// </summary>
    public partial class Handler : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ProtocolHandler.Handler.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::ProtocolHandler.Handler.NamePropertyName]));
            }
            set
            {
                base[global::ProtocolHandler.Handler.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region Application Property
        /// <summary>
        /// The XML name of the <see cref="Application"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string ApplicationPropertyName = "application";
        
        /// <summary>
        /// Gets or sets the Application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Application.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ProtocolHandler.Handler.ApplicationPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Application
        {
            get
            {
                return ((string)(base[global::ProtocolHandler.Handler.ApplicationPropertyName]));
            }
            set
            {
                base[global::ProtocolHandler.Handler.ApplicationPropertyName] = value;
            }
        }
        #endregion
        
        #region Protocol Property
        /// <summary>
        /// The XML name of the <see cref="Protocol"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string ProtocolPropertyName = "protocol";
        
        /// <summary>
        /// Gets or sets the Protocol.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Protocol.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ProtocolHandler.Handler.ProtocolPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Protocol
        {
            get
            {
                return ((string)(base[global::ProtocolHandler.Handler.ProtocolPropertyName]));
            }
            set
            {
                base[global::ProtocolHandler.Handler.ProtocolPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace ProtocolHandler
{
    
    
    /// <summary>
    /// A collection of Handler instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::ProtocolHandler.Handler), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::ProtocolHandler.HandlerSet.HandlerPropertyName)]
    public partial class HandlerSet : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::ProtocolHandler.Handler"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string HandlerPropertyName = "handler";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override string ElementName
        {
            get
            {
                return global::ProtocolHandler.HandlerSet.HandlerPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::ProtocolHandler.HandlerSet.HandlerPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::ProtocolHandler.Handler)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::ProtocolHandler.Handler"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::ProtocolHandler.Handler"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::ProtocolHandler.Handler();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::ProtocolHandler.Handler"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::ProtocolHandler.Handler"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::ProtocolHandler.Handler this[int index]
        {
            get
            {
                return ((global::ProtocolHandler.Handler)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::ProtocolHandler.Handler"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::ProtocolHandler.Handler"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::ProtocolHandler.Handler this[object name]
        {
            get
            {
                return ((global::ProtocolHandler.Handler)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::ProtocolHandler.Handler"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="handler">The <see cref="global::ProtocolHandler.Handler"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Add(global::ProtocolHandler.Handler handler)
        {
            base.BaseAdd(handler);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::ProtocolHandler.Handler"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="handler">The <see cref="global::ProtocolHandler.Handler"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Remove(global::ProtocolHandler.Handler handler)
        {
            base.BaseRemove(this.GetElementKey(handler));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::ProtocolHandler.Handler"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::ProtocolHandler.Handler"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::ProtocolHandler.Handler GetItemAt(int index)
        {
            return ((global::ProtocolHandler.Handler)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::ProtocolHandler.Handler"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::ProtocolHandler.Handler"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::ProtocolHandler.Handler GetItemByKey(string name)
        {
            return ((global::ProtocolHandler.Handler)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}