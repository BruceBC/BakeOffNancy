using System;
namespace TodoApi.Models
{
    public class Todo
    {
        public string Text { get; set; }
        public bool Completed { get; set; }

        public Todo()
        {
        }
    }
}
