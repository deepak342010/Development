using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class QueueController : Controller
    {
        private readonly TestDbContext _context;

        public QueueController(TestDbContext testDbContext)
        {
            this._context = testDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var list = from q in _context.TBL_QUEUE
                       join p in _context.TBL_PROCESS
                       on q.IN_PROCESS_ID equals p.IN_PROCESS_ID //into ps
                       //from p in ps.DefaultIfEmpty()
                       select new TblQueue
                       {
                           VC_PROCESS_NAME = p.VC_PROCESS_NAME,
                           IN_QUEUE_ID = q.IN_QUEUE_ID,
                           VC_QUEUE_NAME = q.VC_QUEUE_NAME
                       };
            //var list = _context.TBL_QUEUE.FromSqlRaw($"USP_QUEUE");
            return View(await list.ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.ProcessList =await _context.TBL_PROCESS.ToListAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("IN_QUEUE_ID,IN_PROCESS_ID,VC_QUEUE_NAME")] TblQueue tblQueue)
        {
            if (ModelState.IsValid)
            {
                 _context.TBL_QUEUE.Add(tblQueue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblQueue);
        }
    }
}
