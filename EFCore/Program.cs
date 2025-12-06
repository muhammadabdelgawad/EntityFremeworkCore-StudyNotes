using EFCore;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

var _dbContext = new AppDbContext();

#region Add & Save Employee To Database
//var employee01 = new Employee
//{
//    Name = "Muhammad"
//};

//_dbContext.Employees.Add(employee01); -- Add Employee 
//_dbContext.SaveChanges(); -- Save Employee to DataBase 
#endregion

#region Add & Save  Blog & Author to Database

//var blog = new Blog { Url = "test01" };

//_dbContext.Blogs.Add(blog);
//_dbContext.SaveChanges();



//var author = new Author
//{
//    FirstName = "Muhammad",
//    LastName = "Abdelgawad"
//};

//_dbContext.Authors.Add(author);
//_dbContext.SaveChanges();


#endregion

#region Add & Save Order to Database

//var order = new Order { Amount = 200 };
//_dbContext.Orders.Add(order);
//_dbContext.SaveChanges();
//Console.WriteLine("Data Saved Successfully!");
#endregion

#region  Add Blog & Check if Blog exists
//using (var _dbContext = new AppDbContext())
//{
//    _dbContext.Database.EnsureCreated();

//    var blog = _dbContext.Blogs.FirstOrDefault(b => b.Url == "www.google.com");

//    if (blog == null)// not exists
//    {
//        _dbContext.Blogs.Add(new Blog { Url = "www.google.com" });
//        _dbContext.SaveChanges();
//        Console.WriteLine("Blog Added Successfully!");
//    }
//}
#endregion

#region Read & Display Stocks from Database
//var stocks = _dbContext.Stocks.ToList();
//foreach (var stock in stocks)
//{
//    Console.WriteLine($"Id: {stock.Id}, Name: {stock.Name}, Symbol: {stock.Symbol}, Sector: {stock.Sector}, Industry: {stock.Industry}, Balance: {stock.Balance}");
//}

#endregion

#region Select Item Using Find

//var stock = _dbContext.Stocks.Find(100);
//Console.WriteLine($"Id: {stock.Id}, Name: {stock.Name}");

#endregion

#region Filter Data - Where 

//var stock = _dbContext.Stocks.Where(s => s.Balance > 90000).ToList();

//foreach (var s in stock)
//{
//	Console.WriteLine($"Id: {s.Id},  Balance: {s.Balance}");
//} 

#endregion

#region Select Specific Columns & Display  -Select - Using Anonymous Type
//var stock = _dbContext.Stocks.Select(x => new { Id = x.Id, Name = x.Name });

//foreach (var s in stock)
//{
//    Console.WriteLine($"Id: {s.Id},  Name: {s.Name}");
//} 
#endregion

#region Grouping Data - GroupBy 

//var stocks = _dbContext.Stocks
//    .GroupBy(s => s.Industry)
//    .Select(x => new { Industry = x.Key, Count = x.Count()});

//foreach (var stock in stocks)
//{
//    Console.WriteLine($"Industry: {stock.Industry},  Count: {stock.Count}");
//}

#endregion

#region Tracking

/// - Enable Tracking  -EF Core Tracks Changes on Balance Property
//var stock = _dbContext.Stocks.SingleOrDefault(s => s.Id == 1);
//stock!.Balance += 5000;
//_dbContext.SaveChanges();

/// - Disable Tracking - Using AsNoTracking() Method
//var stock = _dbContext.Stocks.AsNoTracking().SingleOrDefault(s => s.Id == 1);  
//stock!.Balance += 5000;
//_dbContext.SaveChanges();

/// Disable Tracking for All Queries "Change EF Core Default Tracking"
//_dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;


#endregion











