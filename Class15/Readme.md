![cf](http://i.imgur.com/7v5ASc8.png) Class 15
=====================================

## Lecture
1. Testing Controllers in MVC


1. For a Database connection usign a DBContext:

```csharp

public void MyTestMethod()
{
	DbContextOptions<HunterDbContext> options = new DbContextOptionsBuilder<HunterDbContext>()
            .UseInMemoryDatabase("MyDbName")
            .Options;

	using (HunterDbContext _context = new HunterDbContext(options))
	{
	   MaterialController controller = new MaterialController(_context);
	   int tableCount = controller.Get().Count();
	   Assert.Equal(0, tableCount);

	}
}
 

```

# Assignments

## Readings
1. [Testing Controller Logic MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing)
1. [Unit Testing](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/unit-testing/creating-unit-tests-for-asp-net-mvc-applications-cs)
