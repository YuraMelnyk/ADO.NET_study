# ADO.net

## What is ADO?

  * ADO is a Microsoft technology
  * ADO stands for ActiveX Data Objects
  * ADO is a Microsoft Active-X component
  * ADO is automatically installed with Microsoft IIS
  * ADO is a programming interface to access data in a database

## ADO.NET Overview

  ADO.NET provides consistent access to data sources such as SQL Server and XML, and to data sources exposed through OLE DB and ODBC. Data-sharing consumer applications can use ADO.NET to connect to these data sources and retrieve, handle, and update the data that they contain.
  
  ADO.NET separates data access from data manipulation into discrete components that can be used separately or in tandem. ADO.NET includes .NET Framework data providers for connecting to a database, executing commands, and retrieving results. Those results are either processed directly, placed in an ADO.NET DataSet object in order to be exposed to the user in an ad hoc manner, combined with data from multiple sources, or passed between tiers. The DataSet object can also be used independently of a .NET Framework data provider to manage data local to the application or sourced from XML.
  
  The ADO.NET classes are found in System.Data.dll, and are integrated with the XML classes found in System.Xml.dll. For sample code that connects to a database, retrieves data from it, and then displays that data in a console window, see ADO.NET Code Examples.
  
  ADO.NET provides functionality to developers who write managed code similar to the functionality provided to native component object model (COM) developers by ActiveX Data Objects (ADO). We recommend that you use ADO.NET, not ADO, for accessing data in your .NET applications.
  
  ADO.NET provides the most direct method of data access within the .NET Framework. For a higher-level abstraction that allows applications to work against a conceptual model instead of the underlying storage model, see the <a href ="https://github.com/YuraMelnyk/ADO.NET_study/tree/master/ProjectsFromTroelsen/EntityFramework">ADO.NET Entity Framework</a>.

### Authors

* **Yura Melnyk** - *Initial work* - [YuraMelnyk](https://github.com/YuraMelnyk)
