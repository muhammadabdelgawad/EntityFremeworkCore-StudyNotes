using EFCore;
using EFCore.Models;

//var _dbContext = new AppDbContext();

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
//        _dbContext.Blogs.Add(new Blog { Url = "www.google.com"});
//       _dbContext.SaveChanges();
//         Console.WriteLine("Blog Added Successfully!");
//    }
//}
#endregion

