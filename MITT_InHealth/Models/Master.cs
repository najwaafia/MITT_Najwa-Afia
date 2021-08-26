using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MITT_InHealth.Models
{
    public class Master
    {
        public string SkillID { get; set; }
        public string SkillName { get; set; }
    }
    //public class MovieDBContext : DbContext
    //{
    //    public DbSet<SkillID> Movies { get; set; }
    //}
}