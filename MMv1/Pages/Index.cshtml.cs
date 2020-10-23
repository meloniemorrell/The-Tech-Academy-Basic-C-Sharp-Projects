using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MMv1.Pages
{
    public class IndexModel : PageModel
    {
        public string serverTime = String.Empty;
        public void OnGet()
        {
            serverTime = DateTime.Now.ToString("g");
        }
    }
}
