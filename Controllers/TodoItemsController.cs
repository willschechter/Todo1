using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo1.Api.Models;
using Todo1.Api.Services;

namespace Todo1.Api.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoItemsController : ControllerBase
    {
        private ITodoRepository repository;
        public TodoItemsController(ITodoRepository todoRepository)
        {
            repository = todoRepository ??
            throw new ArgumentNullException(nameof(todoRepository));
        }
        [HttpGet]
        public IActionResult GetTodos()
        {
            var result = repository.GetAllTodoItems();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


    }    

    }
