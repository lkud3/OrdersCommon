This project aims to develop skills in Windows Desktop Application Developing on C# using Visual Studio. During this work, I enhanced my knowledge in configuring my local database from the pre-build schema, coding in C# .NET 6.0 using various Object-Oriented design patterns, connecting the work of the application with the database and ensuring the smooth data transfer between them, enhancing the independent work
of Logic, Data and UX layers by inheritance and coupling. This application using such patterns as classes, interfaces, visitors, builders, observer and the graphics is made with Windows Forms.

The application represents the part of complex business logic, depicting the work of one of the departments, in this case the Orders branch. 
It consists of various tables depicting the information from databases like Customers, Stores, Suppliers and etc., as well as Master table that gives an opportunity of configuring the orders,
each consists of items (details) denoted by master_detail table. 
Each of the master records can be edited, as well as its details, which are the dropdowns connected to the Items table. 
The final application is a great example of complex logical system that operates syncrounisly with the database, that can be easily replaced with remote one.

The Local Database works on SQL Server Management Studio 20 and can be found in DB folder along with its schema for creating from scratch.

Settings.json has all the paths for DB connection, change it according to your topology.
