using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        public string Name { get; set; }

        public Guid TodoId { get; set; }
        public Todo Todo { get; set; }
        
        public User()
        {
        }
    }
}
