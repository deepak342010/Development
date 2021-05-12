using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Edit(int? processId)
        {
            if (processId == null)
                return NotFound();

            var process = _context.TblProcess.Find(processId);
            if (process == null)
                return NotFound();

            return View(process);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int processId, TblProcess tblProcess)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblProcess);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcessExists(tblProcess.IN_PROCESS_ID))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tblProcess);
        }
        public IActionResult Details(int? processId)
        {
            if (processId == null)
            {
                return NotFound();
            }

            var process = _context.TblProcess
                .FirstOrDefault(m => m.IN_PROCESS_ID == processId);
            if (process == null)
            {
                return NotFound();
            }

            return View(process);
        }


        private bool ProcessExists(int id)
        {
            return _context.TblProcess.Any(e => e.IN_PROCESS_ID == id);
        }
    }
}
