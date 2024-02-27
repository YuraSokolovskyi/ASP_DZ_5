using Microsoft.AspNetCore.Mvc;

namespace ASP_DZ_5
{
    public class GettimesuniversalController : Controller
    {
        public IActionResult GetUtcTimes()
        {
            return Content(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + " UTC", "text/plain");
        }

        public IActionResult GetCurrentTimes(string param)
        {
            switch (param)
            {
                case "d":
                    return Content(DateTime.Now.ToString("yyyy-MM-dd"), "text/plain");
                case "t":
                    return Content(DateTime.Now.ToString("HH:mm:ss"), "text/plain");
                default:
                    return Content(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "text/plain");
            }
        }
    }
}
