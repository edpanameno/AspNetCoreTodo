using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            
            var item2 = new TodoItem
            {
                Title = "Learn Sharepoint Web Parts",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            var item3 = new TodoItem
            {
                Title = "Review React/Typescript",
                DueAt = DateTimeOffset.Now.AddDays(3)
            };

            var item4 = new TodoItem
            {
                Title = "Fix iphone battery/internal antenna",
                DueAt = DateTimeOffset.Now.AddMonths(3)
            };

            return Task.FromResult(new [] { item1, item2, item3, item4 });
        }
    }
}