------------------------------------- Assignment 2 README -------------------------------


2022-11-09

1043 Created  a default ASP.NET Core MVC application 
-using .net Core 3. LTS
-Individual accounts 
-keept the html default 
-added the razot runtime 
-reviewed the packages and i have it installed 

1047 commented the ssl port inorder to run it in the lab.
1048 Tring to run the project 
1049 works perfectly now going on next 
1050 creating the github repo..

2022-10-25 

1114 removed the flag (options => options.SignIn.RequireConfirmedAccount = true) form the startup.cs file line 33.
1121 build the app and ran it.... IT works perfctly!!
1125 Reviewed the github and uppdating the readme.md inside the github 
1126 ALL DONE FOR THE DAY.

2022-11-03 

0056 realized that i made a mistake and not selected the MVC app while creating the project so i made a new project.
0112 downloaded the vapor bootstrap theme from the bootswatch.com and replacing the contents of the local bootstrap file. 
0115 changed the link from bootstrap.min.css to bootstrap.css in _Layout.cshtml file.
0121 changed the class of the navigation bar from " navbar-light bg-white " to  "navbar-dark bg-primary" in the _Layout.cshtml file.
0125 removed the " text-dark " form the class of <li> in the _Layout.cshtml file.
0128 added " text-white-50 bg-primary " to the footer class of the _Layout.cshtml file.
0131 removed reference of " text-dark " from the file _LoginPartial.cshtml
0142 Completed setting up the bootstrap file.
0206 added the additional stylesheets and scripts to use in the _Layout.cshtml file.
0217 added the dropdown list
							0226 i can see the content menagement but i cannot see the actual dropdown menu hope to solve this in the class tomorrow.
0254 added 3 new projects to and moved the data folder to the QaasimBooks.DataAcces.
0304 installed different pacakages in the QaasimBooks.DataAcceess
0307 deleted the migrations folder. 
0336 installed all the packages 
0338 deleted the default class1.cs files
0342 as i build the project there is an error in the startup.cs 
0407 modified the models folder name and moved it
0414 got the error for the ErrorViewModel but resolved it
0421 created the file called SD.cs
0422 added project reference 
0425 added customers area to Areas
0428 moved the HomeController to the areas folder 
0431 edited the HomeController.sc and added the line [Area("Customer")]
0440 created a home folder inside the views in Areas
0450 i moved the home folder under the views into the views folder under the Areas
1037 moved the _viewimports and _viewstart under the ares folder
1041 changed the path of _ViewStart 
1045 added a new area named admin in the area folder 
1046 deleted the data and models and controller folder
1051 had an error from the start i was not able to get dropdown to work but is solved now cause i added the data-toggle="dropdown"
1052 added a message so it looks nice
1053 FINALLYYY DONEEE -----------------Assignment part-1

2022-11-8

1030 Starting the--- part 2
1054 added a new migration in the QaasimBook.DataAccess project and the file name is " 20221108154957_DefaultIdentityMigration.cs "
1057 updated the database 

2022-11-13 

2346 started to work on the assigment again 
2357 added a new model category model
2359 added the code for the string name and ID in the category model. 

2022-11-14 

0009 added the migration with add-migration command.
0019 added the using statement and "public DbSet<Category> Categories { get; set; }"
0026 ERROR again ran the add migration command and gave the error  "" The name 'AddCategoryToDb' is used by an existing migration. ""
0039 removed old migraiton and then added the new migration 
0041 updated the database 
0042 checked the SQL SOE and confirmed then category table in it 
0045 added the folder named Repository 
0048 inside the folder added another folder named IRepository
0059 modified the content and the using statements 
0115 created a Repository.cs class in the Repository folder 
0119 implemented the potentail fixes and interface
0126 MOdified teh code to create the constructor and dependency injection DI
0130 created the interface ICategoryRepository.cs under the iRepository folder 
0131 created the class file named CategoryRepository.cs class file under the Repository folder 
0140 modified the CategoryRepository.cs class file and added the using statements and the message for formal parameters
0144  modified the categoryRepository interface 
0146 error occered in the CategoryRepository.cs 
0149 resolved the error and automatically updated the Update() method.
1951 added modifiaction to the CategoryRepository.cs 
2103 realized that i did spelling mistake int the category model so changing it.
2115 i am leaving it as it is as i will use the same name from now.
2120 added a new interface named ISP_Call.cs extends IDisposable  
2213 installed the package dapper and the statement " using Dapper; "
2228 modified the contents of ISP_Call.cs file 
2248 added a new class in the REpository folder and added the statements and implemented  the ISP_Call interface
2257 added the additional using statements for the connection to the database 
2302 added the additional statements "  using Microsoft.Data.SqlClient; "
2355 added the new interface named UnitOfWork under the IRepository folder 
2358 modified the contents of it 
2359 added the new class named UnitOfWork.cs 

2022-11-15 

0004 modified the contents of the class UnitOfWork and made sure it implements the interface IUnitOfWork
0011 added the code to make the interface accessable by the project in the startup file but its showning the namespace error line 36 i will solve it later
0119 added a new folder named controllers and in the added a new file CategoryController.cs 
0141 added the view inside category folder and pasted the code given.
0151 added link to the category page in _layout page.
1024 after the whole night of struggle i found that the error is because the interfaces and the classes are not public 
1025 changed eveythiing to public still have the error of UnitOfWork class
1033 there was a spelling mistake in the category controller file solved it finally 
1045 completed uptill making the categorycontroller 
1345 ERROR:
				The type 'QaasimBooks.DataAccess.Repository.UnitOfWork' cannot be used as type parameter 'TImplementation' in the generic type or method 
				'ServiceCollectionServiceExtensions.AddScoped<TService, TImplementation>(IServiceCollection)'. There is no implicit reference conversion 
				from 'QaasimBooks.DataAccess.Repository.UnitOfWork' to 'QaasimBooks.DataAccess.Repository.IRepository.IUnitOfWork'.	
				QaasimBookStore	C:\Users\qaasi\Source\Repos\Qdesai\QaasimBookStore\QaasimBookStore\Startup.cs	

2022-11-19 

1530 it has been 3 days i am trying to solve this ****** error 
1659 i tried to modify the <itemgroup> in the QaasimBookStore.csproj file.
THIS error caused me a lot of time and because of this i cannot move any further.


2022-11-23 

1908 FINALLY AFTER TRYING FOR 6 DAYS I GOT A SOLUTION FOR THE ERROR there was a mistake in the class UnitOfWork and i added the reference " : IUnitOfWork "
1914 added the category.js file in the www.root/js folder 
1954 added the upsert method in the CategoryController 
2002 Createed a new view Upsert.cshtml
2026 added a new partial view to the Views/ folder
2034 added contents to the _CreateAndBackToListButton.cshtml file
2036 added a new view _EditAndBackToListButton.cshtml file 
2040 added contents to _EditAndBackToListButton.cshtml file
2042 chaged the contents of the file Upsert.cshtml
2245 i was not able to navigate in the application so i added the controller routes
2339 At last i found out where the problem was i pasted the _viewsImports and viewStart file in the Category folder 
2339 created and upsert post method in the category controller 
2346  added the delete method in the categoryController 

Started part3 
2348 ran the app nthing shows up. it says the save() method is not defined 
2350 created the CoverType.cs in the models folder

2022-11-24
0105 Error System.NotImplementedException: 'The method or operation is not implemented.'
0205 stuck on this error trying to find a solution

2022-11-25
1655 created the file CovertypeRepository.cs
1512 added the contents to the file 
1520 created the interface ICoverTypeRepository.cs
1525 added the contents to the file
1602 added the link to the ICoverTypeRepository and the CoverTypeRepository
1201  found my mistake so i added this in the ApplicationDbContext.cs file 
		public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }

2022-11-28

1853 going to add the migration to the database for the covertype
1909 added migration 20221129000441_AddCoverTypeToDb
1917 added the link to Cover Type page in the nav bar
1920 created the controller named CoverTypeController 
1940 added all the mehods and links to the CoverTypeController.cs 
1942 created the folder named CoverType under the Views
1950 added the index.cshtml file 
1951 added the coverType.js file 
1957 added contents to the js file 
2004 added the connection between the view and the js file <script src="~/js/coverType.js"></script>
2009 created the upsert.cshtml view file 
2013 added the contents to the file 
2018 added the model file " Product.cs " 
2211 added contents to the Product.cs file					// Ask andrew about the Categoryid and CategoryId
2215 trying to do the migration update but it was failing again and again 
2221 there was an syantax error missing "}" so added that add good to go 
2223 added the migration "AddProductToDb"  to the database 20221129033148_AddProductToDb
2242 changed the contents of the products model so the Title, ISBN, Author are required.
2248 added the new migration 20221129034432_AddValidationToProduct
2305 createed a new file ProductRepository 
2311 added contents to the file
2315 created the IProductRepository file 
2319  added contents to it
2323 added product to Iunitofwork and unitofwork
2324 no errors in the code running it 
2327 added the ProductController
2357 added the product.js file 

2022-11-29

0032 added the Index and Upsert view 
0045 created the ProductVM 
0053 added contents to the ProductVM class 
0054 had an error for the namespace 
0114 completed the changes in the ProductController
0117 still there is the error of the namespace in ProductVM and Productcontroller 
0123 Modified the API call to include the category and covertype properties
0132 modified the iNDEX VIEW OF THE PRODUCTS 
0134 modified the product.js file 