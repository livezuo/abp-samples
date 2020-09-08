﻿using TemplateReplace.Email;

namespace TemplateReplace.Web.Pages
{
    public class IndexModel : TemplateReplacePageModel
    {
        private readonly IEmailService _emailService;
        public string EmailBody { get; set; }

        public IndexModel(IEmailService emailService)
        {
            _emailService = emailService;
        }
        
        public async void OnGet()
        {
            EmailBody = await _emailService.SendAsync();
        }
    }
}