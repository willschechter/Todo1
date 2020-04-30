using System.Collections.Generic;
using Todo1.Api.Models;

namespace Todo1.Api.Services
{
    public class TodoRepository : ITodoRepository
    {
        private List<TodoItem> _items = new List<TodoItem>()
        {
            new TodoItem{ Id =1, Action="thing one.", Isdone=true},
            new TodoItem{ Id =2, Action="thing two.", Isdone=false}

            };
            public IEnumerable<TodoItem> GetAllTodoItems()
            {
                return _items;
            }
        }
    }
