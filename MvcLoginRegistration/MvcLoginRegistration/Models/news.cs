using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MvcLoginRegistration.Models
{
    public class news
    {

        public int NewsId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int  uid { get; set; }


    }
}