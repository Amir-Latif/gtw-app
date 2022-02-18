# GTW App

* GTW App is a web application that displays the GTW products
* The app is built according to the requirements of GTW

## Installation

1. Clone the code
2. Make sure you have the following installed in your system (in the same order)  
2.1. [ASP.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)    
2.2. Entity Framework Core  
** If Entity Framework Core is not installed in your system, run ```dotnet tool install --global dotnet-ef```
3. In the project root directory, run ```dotnet ef database update```

## Running the application

* run ```dotnet run```

## Workflow
* The entry page of the application displays the products and you can display the details of each product using "المزيد"
* If a URL with an invalid product ID is used, an error page is displayed

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
