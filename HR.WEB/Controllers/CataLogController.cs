using HR.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.WEB.Controllers
{
    public class CataLogController : Controller
    {
        private readonly CatalogDAL _context;

        public CataLogController(CatalogDAL context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> FilterOne()
        {
            var level = await _context.GetDecipline();
            ViewBag.DList = level;
            return View();
        }
    }
}
