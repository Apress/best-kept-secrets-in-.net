@echo off
REM: Command File Created by Microsoft Visual Database Tools
REM: Date Generated: 4/26/2004
REM: Authentication type: SQL Server
REM: Usage: CommandFilename [Server] [Database] [Login] [Password]

if '%1' == '' goto usage
if '%2' == '' goto usage
if '%3' == '' goto usage

if '%1' == '/?' goto usage
if '%1' == '-?' goto usage
if '%1' == '?' goto usage
if '%1' == '/help' goto usage

osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Categories.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustomerCustomerDemo.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustomerDemographics.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Customers.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Employees.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.EmployeeTerritories.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Order Details.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Orders.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Products.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.ProductsDS.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.ProductsTDS.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Region.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Shippers.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Suppliers.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Territories.tab"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Categories.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustomerCustomerDemo.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustomerDemographics.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Customers.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Employees.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.EmployeeTerritories.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Order Details.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Orders.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Products.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.ProductsDS.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.ProductsTDS.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Region.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Shippers.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Suppliers.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Territories.kci"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Categories.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustomerCustomerDemo.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustomerDemographics.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Customers.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Employees.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.EmployeeTerritories.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Order Details.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Orders.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Products.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.ProductsDS.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.ProductsTDS.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Region.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Shippers.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Suppliers.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Territories.fky"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Categories.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustomerCustomerDemo.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustomerDemographics.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Customers.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Employees.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.EmployeeTerritories.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Order Details.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Orders.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Products.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.ProductsDS.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.ProductsTDS.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Region.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Shippers.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Suppliers.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Territories.ext"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Alphabetical list of products.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Category Sales for 1997.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Current Product List.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Customer and Suppliers by City.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Invoices.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Order Details Extended.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Order Subtotals.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Orders Qry.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Product Sales for 1997.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Products Above Average Price.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Products by Category.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Quarterly Orders.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Sales by Category.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Sales Totals by Amount.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Summary of Sales by Quarter.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Summary of Sales by Year.viw"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustOrderHist.prc"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustOrdersDetail.prc"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.CustOrdersOrders.prc"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Employee Sales by Country.prc"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Sales by Year.prc"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.SalesByCategory.prc"
if %ERRORLEVEL% NEQ 0 goto errors
osql -S %1 -d %2 -U %3 -P %4 -b -i "dbo.Ten Most Expensive Products.prc"
if %ERRORLEVEL% NEQ 0 goto errors

goto finish

REM: How to use screen
:usage
echo.
echo Usage: MyScript Server Database User [Password]
echo Server: the name of the target SQL Server
echo Database: the name of the target database
echo User: the login name on the target server
echo Password: the password for the login on the target server (optional)
echo.
echo Example: MyScript.cmd MainServer MainDatabase MyName MyPassword
echo.
echo.
goto done

REM: error handler
:errors
echo.
echo WARNING! Error(s) were detected!
echo --------------------------------
echo Please evaluate the situation and, if needed,
echo restart this command file. You may need to
echo supply command parameters when executing
echo this command file.
echo.
pause
goto done

REM: finished execution
:finish
echo.
echo Script execution is complete!
:done
@echo on
