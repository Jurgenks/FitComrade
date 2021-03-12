using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FitComrade.Entities;

namespace FitComrade.Models
{
    public class Order
    {
        //Identification
        public int ID { get; set; }
        public string Username { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        //Payment
        public decimal TotalPrice { get; set; }
        [Required]
        public string Payment { get; set; }
        [Required]
        public string Bank { get; set; }
        //Date
        public System.DateTime OrderDate { get; set; }
        //Items
        [Required]
        public List<Item> Items { get; set; }
    }
}
