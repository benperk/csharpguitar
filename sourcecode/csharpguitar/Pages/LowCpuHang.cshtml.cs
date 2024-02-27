using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csharpguitar.Pages
{
    public class LowCpuHangModel : PageModel
    {
        public string _globalString = "global";
        public void OnGet()
        {
            //lock (_globalString)
            //{
            //    _globalString = "changed in OnGet() before sleep";
            //    System.Threading.Thread.Sleep(45000);
            //    _globalString = "changed in OnGet() after sleep";
            //}
        }
    }
}
