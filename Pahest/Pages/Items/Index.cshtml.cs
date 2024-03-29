﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pahest.Models;

namespace Pahest.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly Pahest.Models.PahestContext _context;

        public IndexModel(Pahest.Models.PahestContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
