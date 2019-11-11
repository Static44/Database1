using Database1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


//Data Access Layer - DAL

namespace Database1.DAL
{


    public class BasketballContext : DbContext
    {
        //Constructor that passes the class name to DBContext
        public BasketballContext()
            : base("BasketballContext")
        {

        }

        //DBSet works the same format as List - part of the entity framework NuGet
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<NewPlayer> NewPlayers { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}