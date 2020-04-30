using System.Collections.Generic;
using Todo1.Api.Models;

namespace Todo1.Api.Services
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAllTodoItems();
    }
}