using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace WebApiEF.Helper
{
    public class TestActionLibroAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Pasa por OnActionExecuted");
            throw new System.NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("Pasa por OnActionExecuting");
            throw new System.NotImplementedException();
        }
    }
}
