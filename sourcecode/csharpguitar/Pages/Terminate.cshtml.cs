using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csharpguitar.Pages
{
    public class TerminateModel : PageModel
    {
        public void OnGet()
        {
            ThisIsARecursiveFunctionUsedToTriggerAStackOVerflow();
        }
        private static void ThisIsARecursiveFunctionUsedToTriggerAStackOVerflow()
        {
            //This will cause a Stack Overflow exception and kill the process
            for (int i = 0; i < 10000; i++)
            {
                ThisIsARecursiveFunctionUsedToTriggerAStackOVerflow();
            }
        }
    }
}
