using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private static List<TodoItem> todoList = new List<TodoItem>
        {
            new TodoItem
            {
                Id = 1,
                Task = "Sample Task",
                IsComplete = false,
            },
        };

        public IActionResult Index()
        {
            return View(todoList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                item.Id = todoList.Count + 1;
                todoList.Add(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = todoList.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(TodoItem item)
        {
            var existingItem = todoList.FirstOrDefault(t => t.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Task = item.Task;
                existingItem.IsComplete = item.IsComplete;
                return RedirectToAction("Index");
            }
            return View(item);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = todoList.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = todoList.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                todoList.Remove(item);
            }
            return RedirectToAction("Index");
        }
    }
}
