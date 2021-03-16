using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitComrade.Pages.Login;

namespace FitComrade.Entities
{
    public class Profile
    {
        public int LoginID { get; set; }
        public string SessionID { get; set; }
        public string UserName { get; set; }
        public List<Item> ShoppingCart { get; set; }
        public bool Status { get; set; }
        public bool Blocked { get; set; }
    }
}
