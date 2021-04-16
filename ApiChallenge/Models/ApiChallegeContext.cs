using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiChallenge.Models
{
    public class ApiChallegeContext : DbContext
    {
        public ApiChallegeContext(DbContextOptions<ApiChallegeContext> options)
            : base(options)
        {

        }
        public DbSet<Team> Teams { get; set; }   
        public DbSet<Player> Players { get; set; }  
    }
}
