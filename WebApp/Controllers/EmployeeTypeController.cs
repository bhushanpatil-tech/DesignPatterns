using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using EmployeeBusinessService.Models;

namespace WebApp.Controllers
{
    public class EmployeeTypeController : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeeTypeController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: EmployeeType
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee_Type.ToListAsync());
        }

        // GET: EmployeeType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee_Type = await _context.Employee_Type
                .FirstOrDefaultAsync(m => m.ID == id);
            if (employee_Type == null)
            {
                return NotFound();
            }

            return View(employee_Type);
        }

        // GET: EmployeeType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,EmployeeType")] Employee_Type employee_Type)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee_Type);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee_Type);
        }

        // GET: EmployeeType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee_Type = await _context.Employee_Type.FindAsync(id);
            if (employee_Type == null)
            {
                return NotFound();
            }
            return View(employee_Type);
        }

        // POST: EmployeeType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,EmployeeType")] Employee_Type employee_Type)
        {
            if (id != employee_Type.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee_Type);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Employee_TypeExists(employee_Type.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee_Type);
        }

        // GET: EmployeeType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee_Type = await _context.Employee_Type
                .FirstOrDefaultAsync(m => m.ID == id);
            if (employee_Type == null)
            {
                return NotFound();
            }

            return View(employee_Type);
        }

        // POST: EmployeeType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee_Type = await _context.Employee_Type.FindAsync(id);
            _context.Employee_Type.Remove(employee_Type);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Employee_TypeExists(int id)
        {
            return _context.Employee_Type.Any(e => e.ID == id);
        }
    }
}
