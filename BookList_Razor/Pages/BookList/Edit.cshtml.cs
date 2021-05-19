using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_Razor.Pages.BookList
{
    public class EditModel : PageModel
    {
        private readonly DataBaseContext _db;

        public EditModel(DataBaseContext db)
        {
            _db = db;
        }
        [ModelBinder]
        public Book Book { get; set; }

        public async void OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);
        }
    }
}
