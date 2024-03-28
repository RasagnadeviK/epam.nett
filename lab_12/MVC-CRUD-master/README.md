# MVC-CRUD
Perform basic CRUD operations in .NET MVC. This project interacts with the Database using ADO.NET and performs all the basic CRUD operations. 


# Setup the Database:

Execute the script MVCCRUD.sql in SQL server. 
This will create the Employee table with the corressponding fields or create a table with the following query

CREATE TABLE Employee(
	id int IDENTITY(1,1) NOT NULL,
	name varchar](100) NULL,
	age int NULL
)

#Change the connection String in Web.Config:
Replace the below query to the connection string used in local server

\<add name="EmpConnection" connectionString="Data Source=ServerName;Initial Catalog=DataBaseName;Integrated Security=True"
     providerName="System.Data.SqlClient" />
     
ServerName: Local Name of the server to be added

DataBaseName: Database name for which the script was executed

