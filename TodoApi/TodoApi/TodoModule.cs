using System;
using Nancy;
using Nancy.ModelBinding;
using TodoApi.Models;

namespace TodoApi
{
    public class TodoModule : NancyModule
    {
        public TodoModule()
        {
            Get("/todos", args => index(args)); // All Todos
            Get("/todos/{id}", args => ""); // Todos By id
            Post("/todos", args =>create(args)); // Insert new Todo
            Put("/todos/{id}", args => ""); // Update Todo
            Delete("/todos", args => ""); // Deletes Todo
        }

        private Todo index(object args) {
            Todo todo = this.Bind();
            todo.Completed = true;
            todo.Text = "Buy Milk";

            return todo;
        }

        private Todo create(object args) {
            Todo todo = this.Bind();
            return todo;
        }
    }
}
