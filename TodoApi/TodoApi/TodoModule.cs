using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Nancy;
using Nancy.ModelBinding;
using TodoApi.Models;

namespace TodoApi
{
    public class TodoModule : NancyModule
    {
        TodoApiContext context;

        public TodoModule()
        {
            var connection = @"Server=localhost;Port=5432;User ID=postgres;Password=postgres;Database=nancy;";
            var options = new DbContextOptionsBuilder<TodoApiContext>();
            options.UseNpgsql(connection);


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

            var connection = @"Server=localhost;Port=5432;User ID=postgres;Password=postgres;Database=nancy;";
            var options = new DbContextOptionsBuilder<TodoApiContext>();
            options.UseNpgsql(connection);

            using (var context = new TodoApiContext(options.Options))
            {
                context.Add<Todo>(todo);
                context.SaveChanges();
            }

            return todo;
        }
    }
}
