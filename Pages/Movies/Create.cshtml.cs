using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Pages_Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public CreateModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            // valid dữ liệu với model
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Movie.Add(Movie);
            //bat buoc de luu thay doi vao database
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
