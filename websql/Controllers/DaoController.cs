using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using websql.Models;

namespace websql.Controllers
{
    public class DaoController : Controller
    {
        public IActionResult Index()
        {
            Usertbl utbl = new Usertbl();
            List<Usertbl> utblList = new List<Usertbl>();
            DaoClass dao = new DaoClass();
            dao.ExecuteQuery(utblList);
            ViewData["list"] = utblList;

            return View();
            
        }
    }
}