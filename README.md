# Student-Management-System
Creating a small-scale project using .NET Web Forms, this project incorporates segments of a student login system along with diverse functions distributed across various forms, with a database system.
using C#
SUMMARY 
--------------------
A. FISRT
1. Created a web forms template. 
2. Deleted the given template. 
3. Created a folder Screens > Template > TemplateForms.cs 
4. Created another two Forms in Screen > LoginForms.cs also Screens>DashboardForms.cs
5. Associated both the forms with TemplateForm by assigning base class in view code on right click. 
6. Assigned the base class because once the templateForm is edited we dont have to again edit other forms in basic same formats. 
7. Created and edited forms accordingly by right click properties and also using toolbox. 
8. Gave the properties in buttons by : view code by clicking Application.Exit()
9. Edited all DashboardForms 

B. SECOND 

1. Using custom framework and not entity because creating it with scratch. 
2. Going to SSMS and creating new db 
3. Created a roles table with RolesID as primary key and identity
4. Created another table : Users 
5. Inserting all the data , cloumns , rows in both table 
6. Open vs 
7. Write the code in login forms with various condition of entering no uid, password. Pressing sign in button > doing to dashboard and hide that. No spaces in uid password. 
8. Go to SSMS > tb > programmability > stored procedure > new query 
9. Writing '#' instead of @IsLoginCorrect because it only returns rows which is correct after checking. 

1. Adding a new .NET CLASS LIBRARY with same .net version in the solution explorer > add in vs . 
2. Adding a new class in it. Add > Class > name : DbSQLServer
3. Creating method first for scaler i.e singluar value > GetScalerValue
4. Connecting the sql server inside the function 
5. Add <connection string > inside app.config and connect db from sql db > view 
6. check the connection 
7. New class in StudentManager > New Foler (Utilities)> Add > Class > AppSetting
8. Creating new function for Connection String
9. Before that returning ConfigurationManager in method 
10. Shows error so > refrence > add ref manager> tick on System.ConfigurationManager

THIRD

- Managing branches functionally 

1. Creating BRANCHES folder under Screen in VS. 
2. Making two web forms in it > 1. Branches Info Form   2. Manage Branches Form
3. Setting up forms and all the properties
4. Upon clicking the specific menu bar like : manage branches, it reflecting to other forms by view code > create properties

IN SSMS 
1. Create a new table of branches. 
2. Put all the fields of Branch info 
3. Insert values
4. Create Stored proc of few feilds needed.
5. Creating a new class in utilities > list > Creating methods of dataGridView and stored proc
6. Going back to dbSQLserver.cs file > now executing executeScaler methods
