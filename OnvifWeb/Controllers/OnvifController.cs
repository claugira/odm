using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using odm.player;

namespace OnvifWeb.Controllers
{
    public class OnvifController : Controller
    {
        //
        // GET: /Onvif/

        public string Index()
        {
            //VideoBuffer v = new VideoBuffer(700, 600);
            //return v.TestString();
            return "Test";
        }
    }
}
