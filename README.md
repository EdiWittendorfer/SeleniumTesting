Assignment #2 – Automation
Written in C# with Selenium and NUnit framework.

Configuration folder:
	-Properties: Global Web driver and Property type

BaseClass folder:
	-BaseClass: Initialize used for creating HTML logs, launching driver and navigating to desired testing environment.
	            Teardown used for closing the web driver.
Methods folder:
	-Custom Get and Set methods, each is described in the code.

PageObjects folder::
	-Contains all of the mapped elements used trought testing and custom methods for the web page.

TestCases folder:
	-Contains all of the written test cases that are required in acceptance criteria.

Logs and Screenshot folders:
	-Location where screenshot of failed test cases is stored as well as log of ran test cases.


Acceptance criteria is seperate in 4 different Test cases which is described below.
TC001
	- Visitor user can create an account

TC002
	- Registered user can login
	- Logged in user can log out

TC003
	- Registered user as a Visitor user can reset the password and use it to log in 

TC004
	- Visitor user can search for products 
	- Logged in user can search for products 
	- Logged user can order one or more products, and select Payment at pickup as a Payment method

Ecah step is commented in the code. Tests can be executed trough Test Explorer window. 
TC001 will randomly create different user each time since the test case will throw 
an error which states that the use is already created.
TC002, TC003 and TC004 use the same user which is set up with TC001 in advance.
TC003 can fail if the TC is run without debug mode, sicne sometimes it takes longer than usual for the mail to 
areive in the inbox. (also commented in the code)
