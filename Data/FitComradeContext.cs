using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitComrade.Models;
using FitComrade.ViewModels;

namespace FitComrade.Data
{
    public class FitComradeContext : DbContext
    {
        public FitComradeContext()
        {
        }

        public FitComradeContext (DbContextOptions<FitComradeContext> options)
            : base(options)
        {
        }

        public DbSet<FitComrade.Models.Person> Person { get; set; }

        public DbSet<FitComrade.Models.RegisterModel> RegisterModel { get; set; }

        public DbSet<FitComrade.Models.LogOnModel> LogOnModel { get; set; }

        public DbSet<FitComrade.Models.Products> Products { get; set; }

        public DbSet<FitComrade.Models.Order> Orders { get; set; }

        public DbSet<FitComrade.Models.Cart> Carts { get; set; }

        public DbSet<FitComrade.Models.OrderDetail> OrderDetails { get; set; }

        public DbSet<FitComrade.ViewModels.ShoppingCartViewModel> ShoppingCartViewModel { get; set; }


    }
}
