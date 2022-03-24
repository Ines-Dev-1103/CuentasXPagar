using CuentasxPagar.Models;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Web;
using System.Web.Mvc;

namespace CuentasxPagar.Controllers
{
    public class LoginDatabaseController : Controller
    {
        // GET: LoginDatabase
        public ActionResult Index()
        {
            //DataBase
            Database database = new Database();
            var listausuarios = database.Login.ToList();
            

            return new JsonResult
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = listausuarios

            };
        }
    }
}