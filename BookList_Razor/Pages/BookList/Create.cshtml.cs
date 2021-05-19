using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_Razor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly DataBaseContext _db;

        public CreateModel(DataBaseContext db)
        {
            _db = db;
        }

        public Book Book { get; set; }
        public void OnGet()
        {
        }
    }
}
