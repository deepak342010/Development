using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly TestDbContext _context;
        public CategoryController(TestDbContext testDbContext)
        {
            this._context = testDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var list = from c in _context.TBL_CATEGORY
                       join p in _context.TBL_PROCESS
                       on c.IN_PROCESS_ID equals p.IN_PROCESS_ID
                       select new TblCategory
                       {
                           IN_PROCESS_ID = c.IN_PROCESS_ID,
                           VC_PROCESS_NAME = p.VC_PROCESS_NAME,
                           VC_CATEGORY_NAME = c.VC_CATEGORY_NAME,
                           B_PROMPT = c.B_PROMPT,
                           IN_LASTUPDATED_BY = c.IN_LASTUPDATED_BY
                       };
            return View(await list.ToListAsync());
        }
    }
}
