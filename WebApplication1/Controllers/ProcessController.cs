using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProcessController : Controller
    {
        public readonly TestDbContext _context;
        public ProcessController(TestDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.TblProcess.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TblProcess tblProcess)
        {
            if (ModelState.IsValid)
            {
                _context.TblProcess.Add(tblProcess);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(tblProcess);
        }
    }
}
