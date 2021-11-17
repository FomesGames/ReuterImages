using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReuterImages.Pages
{
    public class UrlTranslationModel : PageModel
    {
        private readonly ILogger<UrlTranslationModel> _logger;

        public UrlTranslationModel(ILogger<UrlTranslationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
