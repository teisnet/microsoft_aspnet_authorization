using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactManager.Pages
{
	// The class is instantiated at each HTTP request
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
		public IndexModel()
		{
			Console.WriteLine(new Guid());
		}

        public void OnGet()
        {

        }
    }
}
