using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NET_Lab4.Data;
using NET_Lab4.Models;

namespace NET_Lab4.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly NET_Lab4.Data.NET_Lab4Context _context;

        public IndexModel(NET_Lab4.Data.NET_Lab4Context context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
