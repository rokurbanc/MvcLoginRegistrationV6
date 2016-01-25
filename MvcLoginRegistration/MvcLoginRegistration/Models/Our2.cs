using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcLoginRegistration.Models
{
    public class Our2 : DbContext
    {
        public System.Data.Entity.DbSet<MvcLoginRegistration.Models.news> news { get; set; }
    }
}