using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentsql.Models
{
    internal class Cart
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string size { get; set; }
        public string shippingAddress { get; set; }
        public DateTime JokeDate { get; set; }
    }
}
