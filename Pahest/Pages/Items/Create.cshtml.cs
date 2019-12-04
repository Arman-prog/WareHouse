using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pahest.Models;

namespace Pahest.Pages.Items
{
    public class CreateModel : PageModel
    {
        private readonly Pahest.Models.PahestContext _context;

        public CreateModel(Pahest.Models.PahestContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Item Item { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            _context.Item.Add(Item);
            Item.Cost = Item.Price * (decimal)Item.Count;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
