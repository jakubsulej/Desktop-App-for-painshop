<p>Paint Shop management software is a desktop application created to maintain an automatic paint shop in production environments. It allows us to save information about when and how much coat had been made by workers. It also helps workers to count component proportions to prepare a new coat from the recipe. The last part of the software is prepared for service staff or paint Shop manager, which allows him to manage user accounts and view work history.</p>

<h2>Software specification</h2>
<p>The solution is a C# WinForms application because many existing IT environments in production still uses Windows XP. That is why it needs a safe solution, which is simple and robust. Data access library with models connects the database with application logic.Sql local database is enough for this type of software, because it does not need an internet connection and additional security.</p>

<h2>Solution deployment</h2>
<p>The solution is divided into three projects. The first one is the user interface - paintshopAppUI with all the business logic needed to display, work, count, and take input from the user. The next one is the SQL database - paintShopDB, with all tables needed for the working application. The last one is DataAccessLibrary, which connects the first two projects.</p>

<h3>DataAccessLibrary</h2>
<p><a href="https://github.com/jakubsulej/Desktop-App-for-painshop/tree/master/DataAccessLibrary">Click to see the DataAccessLibrary code</a></p>
<p>Following good practices, the project uses data models for connecting with each table from the database. Several data access classes were created to take data from the database, process it if needed, and return values. By using Dapper - a Micro ORM, the process of mapping data was much simpler and more efficient. Moreover after refactoring the project, adding the DataAccessLibrary with a Dapper extension was a cleaner and better choice over the previously used ado.net.</p>

<h3>PaintshopDB</h3>
<p><a href="https://github.com/jakubsulej/Desktop-App-for-painshop/tree/master/PaintshopData/dbo/Tables">Click to see the DataBase solution</a></p>
<p>Because the solution is compact and simple, it uses only 4 database tables. dbo.people is a table with users, who have access to enter the solution by logging in and their properties. dbo.history is an output of preparing coats. It stores user name, time, coat type and is being used to be displayed in History form (possibly also printed). dbo.jigs contains data as jig name, and Jignumber (informs on which position in the paint shop the jig is). Table dbo.loggedUsers contains information about the currently logged user and his role (permission). It is being written when the user logs in and erased when a new one logs in.</p>

<h3>Paint Shop App UI</h3>
<p><a href="https://github.com/jakubsulej/Desktop-App-for-painshop/tree/master/Test%20działania%20aplikacji/Views">Click to see the UI solution</a></p>
<p>The user interface part of the solution is a Winforms C# application with all the code being written directly under the UI forms as a common practice in small Winforms. However, unlike the typical WinForms application, this one has a modern design, which required E.g. hiding window controls and making new ones. Also changing the UserContols navigation needed to be updated and written in code to be more readable.</p>

<h2>User login page</h2>
<p><a href="https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Views/Login.cs">Click to see the Login Form code</a></p>
Every worker in the company has its user id, which is numeric or alphanumeric and it is used E.g. to scan when starting workday. The same number should be used in the paint shop management software and it is connected with other user information in the paint shop manager database. Successful login saves the logged-in user information - user name and user access type (login/user).
In the backend the software checks if the database table with currently logged in users is empty. If not it deletes all the information and allows the program to write a new one with the newly logged-in user.

<h2>Shell View/Dashboard form</h2>
<p><a href="https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Views/MainForm.cs">Click to see the Shell View Form code</a></p>
<p>The dashboard of the paint shop management software is a WindowForm and it holds an application and its functions, which are UserContols. The main view also displays the current local time and contains window controls like exit, minimize, and move the window. It allows users to move through the functions of the application and checks for an admin/service permission to access the history and settings.</p>

![grab-landing-page](https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Media/Gif/coatMakeHistory.gif)

<h2>Make coat form</h2>
<p><a href="https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Views/CoatViews/CoatACount.cs">Click to see the Make Coat code</a></p>
<p>Paint shop management software helps production workers avoid mistakes during preparing coats because it automatically counts all needed component proportions to make a coat. Moreover, it does not let the user skip through the process, because every step in the recipe has to be ticked as done before moving to the next one. When two components need to be mixed, it starts a countdown. Until the countdown finishes, the user can't tick it as done.
When all tics are clicked, the software saves to the database pieces of information like currently logged user id, current local time, type of coat, and quantity of coat.</p>

![grab-landing-page](https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Media/Gif/makeCoat.gif)

<h2>Coat History form</h2>
<p><a href="https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Views/LackHistoryForm.cs">Click to see the History Form code</a></p>
<p>The history form was created to manage the crucial information about the coat, such as time, type of coat, and user name who made it. It allows managers and services to control the production process and see if something was not made properly. That eliminates possible mistakes made during the workday.
The other useful feature is deleting data from the history database. It can be made as a single selection or deleting the last 7 days to do it more efficiently.
Furthermore from Coat History form users with permission can also export data as a CSV file, save it in a local machine, and then E.g.  import it to Microsoft Excel.</p>

![grab-landing-page](https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Media/Gif/coatMakeHistory.gif)

<h2>Settings form</h2>
<p><a href="https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Views/SettingForm.cs">Click to see the Settings Form code</a></p>
<p>The setting form has two tabs, each for different operations. The first one is for maintaining the users in the database and the second is for managing jig information in the paint shop.<p>

<h3>User tab</h3>
<p>The settings form is made to allow anyone with an admin type account to add, delete, and update users' data. It displays a list of users who are in the database with their properties, then updates data if needed and save it. Creating a new user requires writing user personal id, password, and role (permission) which the user would have. All the information except username could be changed later by selecting the user row from the Listbox, changing data, and pressing the update button.

![grab-landing-page](https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Media/Gif/settingsFormUsers.gif)
  
<h3>Jig tab</h3>
<p><a href="https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Views/JigViews/JigsSelector1.cs">Click to see the Jig Form code</a></p>
It displays current positions of all 9 jigs in the paint shop. Changing them is possible by pressing the button with a jig position. Then a new window pops up with 6 types of jigs. Selecting one automatically closes the popup window and the new one is being displayed on its position. Saving the values as a CSV file requires pressing save as CSV button and a new window pops up.</p>

![grab-landing-page](https://github.com/jakubsulej/Desktop-App-for-painshop/blob/master/Test%20dzia%C5%82ania%20aplikacji/Media/Gif/settingsFormJigs.gif)

<h2>What I have learned</h2>
<p>That was my first big project made in C#. I have chosen a Winforms application because it was less complex than WPF or asp.net, but still has many useful features similar to a WPF project. I also want to have a wide technology stack in .Net. 
The most important thing for me was to build a real-life application and the idea came up when I was working as an operator in an automatic paint shop. Working with databases, user inputs, user controllers gave me a good background for writing future more complex solutions. Moreover writing methods, conditionals, loops, etc. in more complex and closer to life-like applications was much more fun than iterating it in small console applications.
The key thing while developing the software was to invent a solution on my own, rather than doing tutorial step by step. I have learned how to approach the problems and solve them with knowledge from stack overflow.</p>
