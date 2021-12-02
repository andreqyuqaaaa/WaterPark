using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterPark.Models;

namespace WaterPark.Controllers
{
    public class PostInfoController : Controller
    {
        public IActionResult Post_03()
        {
            var model = new PostInfoViewModel();

            model.ImageUrl = "/Img/Post/03/PashaChiil.jpg";
            model.Desc = "Some description about post";

            return View(model);
        }
    }
}
