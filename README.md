# InterfaceCRUD_Operation
implemented the crud operation by using database through the api with MVC core
steps:-
1.Add a new class in the Models folder by right-clicking on folder > Add > Class.
2.Name your class as Customer and add the following code in the class. 
3.Right-click on Models class and add an interface, name it as "IDataRepository", and add the following code.
4.Let's add an Actions class. Right-click on the Models folder and add a class name it as "CustomerManager" and add the following code in the class.
5.The CustomerManager class in inherited by the IDataRepository interface and all the methods that we have defined in IDataRepository are implemented in this class for CRUD operations.
 
Now, let's add a class as our DbContext class. Right-click on the Models folder and add a new class.
 
Name it as ResturantDbContext and add the following code.
6.ResturantDbContext is inherited by DbContext class of EntityFrameworkCore. Add a new migration by witing the following command in Package-Manager Console.
7.Add the connection string as following in your appsetting.json file.
