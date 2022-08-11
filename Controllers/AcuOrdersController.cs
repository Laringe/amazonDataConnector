using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AmazonDataConnector.Models;
using amazonDataConnector.Data;
using FikaAmazonAPI.Utils;

namespace AmazonDataConnector.Controllers
{
    public class AcuOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AcuOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AcuOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.AcuOrder.ToListAsync());
        }
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }
        public async Task<IActionResult> Amz()
        {
            return View();
        }

        // GET: AcuOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acuOrder = await _context.AcuOrder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acuOrder == null)
            {
                return NotFound();
            }

            return View(acuOrder);
        }

        // GET: AcuOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AcuOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullAcuOrderId,AmzOrderList")] AcuOrder acuOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acuOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acuOrder);
        }

        // GET: AcuOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acuOrder = await _context.AcuOrder.FindAsync(id);
            if (acuOrder == null)
            {
                return NotFound();
            }
            return View(acuOrder);
        }

        // POST: AcuOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullAcuOrderId,AmzOrderList")] AcuOrder acuOrder)
        {
            if (id != acuOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acuOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcuOrderExists(acuOrder.Id))
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
            return View(acuOrder);
        }

        // GET: AcuOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acuOrder = await _context.AcuOrder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acuOrder == null)
            {
                return NotFound();
            }

            return View(acuOrder);
        }

        // POST: AcuOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var acuOrder = await _context.AcuOrder.FindAsync(id);
            _context.AcuOrder.Remove(acuOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcuOrderExists(int id)
        {
            return _context.AcuOrder.Any(e => e.Id == id);
        }
    }
}
