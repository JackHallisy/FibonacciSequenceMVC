using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibonacciSequenceMVC.Controllers
{
    public class FibonacciController : Controller
    {
        // GET: Fibonacci
        public ActionResult Index()
        {
        int[] Fib = new int[20];

            Fib[0] = 0;
            Fib[1] = 1;
                             
            for (int num = 2; num < 20; num++)
            {
                Fib[num] = Fib[num - 1] + Fib[num - 2];
            }

            ViewBag.Fib = Fib;
            return View();
                
            
        }
    }
}
