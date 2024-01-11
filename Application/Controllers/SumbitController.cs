using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Application.Controllers
{
    public class SumbitController : Controller
    {
        private readonly BillingContext _context;

        public SumbitController(BillingContext context)
        {
            _context = context;
        }

        // GET: Sumbit
        public async Task<IActionResult> Index()
        {
              return _context.BillProperts != null ? 
                          View(await _context.BillProperts.ToListAsync()) :
                          Problem("Entity set 'BillingContext.BillProperts'  is null.");
        }
        public async Task<IActionResult> AdminIndex(){
            return _context.BillProperts != null ? 
                          View(await _context.BillProperts.ToListAsync()) :
                          Problem("Entity set 'BillingContext.BillProperts'  is null.");
        }

        // GET: Sumbit/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BillProperts == null)
            {
                return NotFound();
            }

            var billPropert = await _context.BillProperts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (billPropert == null)
            {
                return NotFound();
            }

            return View(billPropert);
        }
        public async Task<IActionResult> AdminDetails(int? id)
        {
            if (id == null || _context.BillProperts == null)
            {
                return NotFound();
            }

            var billPropert = await _context.BillProperts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (billPropert == null)
            {
                return NotFound();
            }

            return View(billPropert);
        }

        // GET: Sumbit/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sumbit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Email,Visited_Palce,Travel_By,vehicle_Name,Purpose_of_Visit,Date_of_Visit,Date_of_Return,Bill_File,Bill_Number,Date_on_Bill,Expense")] BillPropert billPropert)
        {
            if (ModelState.IsValid)
            {
                _context.Add(billPropert);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(billPropert);
        }

        // GET: Sumbit/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BillProperts == null)
            {
                return NotFound();
            }

            var billPropert = await _context.BillProperts.FindAsync(id);
            if (billPropert == null)
            {
                return NotFound();
            }
            return View(billPropert);
        }

        // POST: Sumbit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Email,Visited_Palce,Travel_By,vehicle_Name,Purpose_of_Visit,Date_of_Visit,Date_of_Return,Bill_File,Bill_Number,Date_on_Bill,Expense")] BillPropert billPropert)
        {
            if (id != billPropert.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(billPropert);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BillPropertExists(billPropert.ID))
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
            return View(billPropert);
        }

        // GET: Sumbit/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BillProperts == null)
            {
                return NotFound();
            }

            var billPropert = await _context.BillProperts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (billPropert == null)
            {
                return NotFound();
            }

            return View(billPropert);
        }
        

        // POST: Sumbit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BillProperts == null)
            {
                return Problem("Entity set 'BillingContext.BillProperts'  is null.");
            }
            var billPropert = await _context.BillProperts.FindAsync(id);
            if (billPropert != null)
            {
                _context.BillProperts.Remove(billPropert);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BillPropertExists(int id)
        {
          return (_context.BillProperts?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
     
    
}
