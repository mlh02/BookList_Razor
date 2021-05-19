using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookList_Razor.Model.BookList
{
    public class IndexModel : PageModel
    {
        private readonly DataBaseContext _db;

        public IndexModel(DataBaseContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _db.Books.ToListAsync();
        }
    }
}
