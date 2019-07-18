using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAPI.Models;
using Microsoft.AspNetCore.Cors;

namespace MyAPI.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/Todo")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context){
            _context = context;
            if(_context.TodoItems.Count() == 0 ){
                //if no items
                _context.TodoItems.Add(new TodoItem {Name = "Item1"});
                _context.SaveChanges();
            }
        }
        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems(){
            return await _context.TodoItems.ToListAsync();
        }
        // GET : api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id){
            var todoItem = await _context.TodoItems.FindAsync(id);

            if(todoItem == null){
                return NotFound();
            }
            return todoItem;
        }
        // POST : api/todo
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem item){
            _context.TodoItems.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTodoItem),new { id = item.Id},item);
        }
    }
}