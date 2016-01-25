using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MvcLoginRegistration.Models
{
    public class Picture
    {
        public int userid { get; set; }
        public HttpPostedFileBase File { get; set; }

    }
}