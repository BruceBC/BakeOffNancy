using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Todo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TodoId { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }
        public List<User> Users { get; set; }

        public Todo()
        {
        }
    }
}
