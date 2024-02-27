using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csharpguitar.Pages
{
    public class HandledModel : PageModel
    {
        private readonly ILogger<HandledModel> _logger;
        public HandledModel(ILogger<HandledModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            decimal number = 1000, total = 0;
            try
            {
                decimal percentage = number / total;
            }
            catch (DivideByZeroException divEx)
            {
                //Add some code to turn this on and off as required
                ViewData["StatusMessage"] = $"EXCP - A handled exception just happened: -> {divEx.Message} and logged to Application Insights.";
                var exceptionMessage = divEx.Message;
                _logger.LogError("A handled exception just happened: -> {exceptionMessage}", exceptionMessage);
            }
        }
    }
}