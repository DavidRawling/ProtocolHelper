<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="697d1994-87c9-41c3-a712-e39b9826e8ba" namespace="ProtocolHandler" xmlSchemaNamespace="urn:ProtocolHandler" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationSection name="AppConfiguration" namespace="ProtocolHandler" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="appConfiguration">
      <elementProperties>
        <elementProperty name="Handlers" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="handlers" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/697d1994-87c9-41c3-a712-e39b9826e8ba/HandlerSet" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElement name="Handler" namespace="ProtocolHandler">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/697d1994-87c9-41c3-a712-e39b9826e8ba/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Application" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="application" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/697d1994-87c9-41c3-a712-e39b9826e8ba/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Protocol" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="protocol" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/697d1994-87c9-41c3-a712-e39b9826e8ba/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="HandlerSet" namespace="ProtocolHandler" xmlItemName="handler" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/697d1994-87c9-41c3-a712-e39b9826e8ba/Handler" />
      </itemType>
    </configurationElementCollection>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>