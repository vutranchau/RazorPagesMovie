using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Pages_SinhVien
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DetailsModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public SinhVien SinhVien { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SinhVien = await _context.SinhVien.FirstOrDefaultAsync(m => m.SinhVienID == id);

            if (SinhVien == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
