using Microsoft.AspNetCore.Mvc;

namespace ActionResult_dynamic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CustomHtmlPage()
        {
            // Передаем контент в наш HtmlResult
            string content = "<h1>Добро пожаловать на мою страницу!</h1>";
            return new HtmlResult(content);
        }
    }
}
