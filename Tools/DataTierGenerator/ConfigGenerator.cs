using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace DataTierGenerator
{
	/// <summary>
	/// Generates config files for classes representing a database.
	/// </summary>
	internal static class ConfigGenerator
	{
		/// <summary>
		/// Creates an app.config file that references each generated C# code file for data access.
		/// </summary>
		/// <param name="path">The path where the config file should be created.</param>
		/// <param name="tableList">The list of tables code files were created for.</param>
		/// <param name="databaseName">The name of the database the assembly provides access to.</param>
		/// <param name="connectionString">The connection string used to connect to the database.</param>
		/// <param name="targetNamespace">The namespace that the generated C# classes should contained in.</param>
		/// <param name="daoSuffix">The suffix to append to the name of each data access class.</param>
		internal static void CreateAppConfig(string path, List<Table> tableList, string databaseName, string connectionString, string targetNamespace, string daoSuffix)
		{
			string configXml = Utility.GetResource("DataTierGenerator.Resources.App.config");
			XmlDocument document = new XmlDocument();
			document.LoadXml(configXml);
			
			XmlNode objectFactoryNode = document.SelectSingleNode("/configuration/sharpCore/objectFactory");
			
			foreach (Table table in tableList)
			{
				string className = Utility.FormatClassName(table.Name) + "Data";
				
				XmlNode objectNode = document.CreateElement("object");
				objectFactoryNode.AppendChild(objectNode);
				
				XmlAttribute objectIdAttribute = document.CreateAttribute("id");
				objectIdAttribute.Value = className;
				objectNode.Attributes.Append(objectIdAttribute);

				XmlAttribute objectTypeAttribute = document.CreateAttribute("type");
				objectTypeAttribute.Value = String.Format("{0}.Data.{1}, {0}", targetNamespace, className);
				objectNode.Attributes.Append(objectTypeAttribute);
				
				XmlNode constructorNode = document.CreateElement("constructor");
				objectNode.AppendChild(constructorNode);
				
				XmlNode parameterNode = document.CreateElement("parameter");
				constructorNode.AppendChild(parameterNode);
				
				XmlAttribute parameterValueAttribute = document.CreateAttribute("value");
				parameterValueAttribute.Value = databaseName;
				parameterNode.Attributes.Append(parameterValueAttribute);
				
				XmlAttribute parameterTypeAttribute = document.CreateAttribute("type");
				parameterTypeAttribute.Value = "System.String";
				parameterNode.Attributes.Append(parameterTypeAttribute);
			}
			
			XmlNode addNode = document.SelectSingleNode("/configuration/connectionStrings/add");
			addNode.Attributes["name"].Value = databaseName;
			addNode.Attributes["connectionString"].Value = connectionString;

			SaveDocument(document, Path.Combine(path, "App.config"));
		}
		/// <summary>
		/// Creates an app.config file that references each generated C# code file for data access.
		/// </summary>
		/// <param name="path">The path where the config file should be created.</param>
		/// <param name="tableList">The list of tables code files were created for.</param>
		/// <param name="databaseName">The name of the database the assembly provides access to.</param>
		/// <param name="connectionString">The connection string used to connect to the database.</param>
		/// <param name="targetNamespace">The namespace that the generated C# classes should contained in.</param>
		/// <param name="daoSuffix">The suffix to append to the name of each data access class.</param>
		internal static void CreateMockConfig(string path, List<Table> tableList, string databaseName, string connectionString, string targetNamespace, string daoSuffix)
		{
			string configXml = Utility.GetResource("DataTierGenerator.Resources.App.config");
			XmlDocument document = new XmlDocument();
			document.LoadXml(configXml);

			XmlNode objectFactoryNode = document.SelectSingleNode("/configuration/sharpCore/objectFactory");
			foreach (Table table in tableList)
			{
				string className = Utility.FormatClassName(table.Name) + "Data";

				XmlNode objectNode = document.CreateElement("object");
				objectFactoryNode.AppendChild(objectNode);

				XmlAttribute objectIdAttribute = document.CreateAttribute("id");
				objectIdAttribute.Value = className;
				objectNode.Attributes.Append(objectIdAttribute);

				XmlAttribute objectTypeAttribute = document.CreateAttribute("type");
				objectTypeAttribute.Value = String.Format("{0}.Data.{1}Mock, {0}", targetNamespace, className);
				objectNode.Attributes.Append(objectTypeAttribute);
			}

			XmlNode addNode = document.SelectSingleNode("/configuration/connectionStrings/add");
			addNode.Attributes["name"].Value = databaseName;
			addNode.Attributes["connectionString"].Value = connectionString;
			
			SaveDocument(document, Path.Combine(path, "Mock.config"));
		}
		
		/// <summary>
		/// Saves an XmlDocument to the specified path.
		/// </summary>
		/// <param name="document">The document to save.</param>
		/// <param name="path">The path to save the document to.</param>
		private static void SaveDocument(XmlDocument document, string path)
		{
			using (XmlTextWriter textWriter = new XmlTextWriter(path, Encoding.UTF8))
			{
				textWriter.Formatting = Formatting.Indented;
				textWriter.Indentation = 1;
				textWriter.IndentChar = '\t';

				document.Save(textWriter);
			}
		}
	}
}
