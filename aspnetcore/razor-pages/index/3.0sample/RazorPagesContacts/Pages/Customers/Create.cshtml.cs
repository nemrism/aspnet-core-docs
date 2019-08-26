﻿#region snippet_ALL
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesContacts.Data;
using RazorPagesContacts.Model;
using System.Threading.Tasks;

namespace RazorPagesContacts.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly CustomerDbContext _context;

        public CreateModel(CustomerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        #region snippet_OnPostAsync
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        #endregion
    }
}
#endregion