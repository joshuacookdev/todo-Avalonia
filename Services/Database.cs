using System.Collections.Generic;
using Todo.Models;

namespace Todo.Services
{
    public class Database
    {
        public IEnumerable<TodoItem> GetItems() => new[]
        {
            new TodoItem { Description = "Buy Groceries"},
            new TodoItem { Description = "Water Plants", IsChecked=true},
            new TodoItem { Description = "Bring Plants in from watering"}
        };
    }
}