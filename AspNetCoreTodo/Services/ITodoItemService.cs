using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        // A Task object is similar to Promises in javascript
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}
