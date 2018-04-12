# ![cf](http://i.imgur.com/7v5ASc8.png) Lab 18: Web APIs and Wrap up


## Unit Testing Examples:
- [API Unit Tests] (https://github.com/MidTermProject/Monster-Hunter-API)


```csharp

        [Fact]
        public void TestStatusCode()
        {
            var options = new DbContextOptionsBuilder<TodoDbContext>()
            .UseInMemoryDatabase(databaseName: "getStatusCode")
            .Options;

            //Arrange
            using (var context = new TodoDbContext(options))
            {
                var controller = new TasksController(context);
                
				//Act
                var result = controller.Get(5);
                ObjectResult sc = (ObjectResult)result;


                //Assert
                Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)sc.StatusCode.Value);
            }
        }
```

## Readings
- [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?tabs=visual-studio&view=aspnetcore-2.1)
- [Complex Data Model](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model?view=aspnetcore-2.1)

