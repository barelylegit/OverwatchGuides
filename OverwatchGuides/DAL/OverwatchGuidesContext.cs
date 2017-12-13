using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OverwatchGuides.Models;

namespace OverwatchGuides.DAL
{
    public class OverwatchGuidesContext: DbContext
    {
        public OverwatchGuidesContext(): base("OverwatchGuidesContext") { }


        public DbSet<Hero> Heroes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<HeroComment> HeroComments { get; set; }
    }
}