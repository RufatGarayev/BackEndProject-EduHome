using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EduHome.DAL;
using EduHome.Models;
using EduHome.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class NoticeBoardsController : Controller
    {
        private readonly AppDbContext _context;

        public NoticeBoardsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/NoticeBoards
        public async Task<IActionResult> Index()
        {
            return View(await _context.NoticeBoards.ToListAsync());
        }

        // GET: Admin/NoticeBoards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticeBoard = await _context.NoticeBoards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticeBoard == null)
            {
                return NotFound();
            }

            return View(noticeBoard);
        }

        // GET: Admin/NoticeBoards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/NoticeBoards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Time,Description,IsDeleted,TimeDeleted")] NoticeBoard noticeBoard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(noticeBoard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(noticeBoard);
        }

        // GET: Admin/NoticeBoards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticeBoard = await _context.NoticeBoards.FindAsync(id);
            if (noticeBoard == null)
            {
                return NotFound();
            }
            return View(noticeBoard);
        }

        // POST: Admin/NoticeBoards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Time,Description,IsDeleted,TimeDeleted")] NoticeBoard noticeBoard)
        {
            if (id != noticeBoard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(noticeBoard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticeBoardExists(noticeBoard.Id))
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
            return View(noticeBoard);
        }

        // GET: Admin/NoticeBoards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticeBoard = await _context.NoticeBoards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticeBoard == null)
            {
                return NotFound();
            }

            return View(noticeBoard);
        }

        // POST: Admin/NoticeBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var noticeBoard = await _context.NoticeBoards.FindAsync(id);
            _context.NoticeBoards.Remove(noticeBoard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticeBoardExists(int id)
        {
            return _context.NoticeBoards.Any(e => e.Id == id);
        }
    }
}
