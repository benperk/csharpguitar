using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csharpguitar.Pages
{
    public class HealthCheckModel : PageModel
    {
        public ObjectResult OnGet()
        {
            Random r = new Random();
            var number = r.Next(1, 100);
            if (number % 3 == 0)
            {
                return StatusCode(301, "Moved Permanently.  The requested resource has been assigned a new permanent URI and any future references to this resource SHOULD be done using one of the returned URIs");
            }
            else if (number % 2 == 0)
            {
                return StatusCode(503, "Service Unavailable.  The server is currently unable to handle the request due to a temporary overloading or maintenance of the server. ");
            }
            return StatusCode(200, "OK.  The request has succeeded.");
        }
    }
}
