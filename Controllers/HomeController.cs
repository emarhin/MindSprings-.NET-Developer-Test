using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MindSpringsTest.Models;
using Microsoft.Extensions.Logging;

namespace MindSpringsTest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    [HttpPost]
        public IActionResult Translate(storeResultModel model)
        {
            // Here you can access the entered text via model.TextEntered
            // You can also set the language or any other properties of the model if needed
            // For example:
            // model.Language = "English";
            //
            // model.TextEntered = Request.Form["TextEntered"];
             //model.translatedText = Request.Form["translatedText"];

              // Access the data from the model
        //string enteredText = model.TextEntered;
       // string translatedText = model.TranslatedText;

        // Log the entered text and the translated text
        _logger.LogInformation( Request.Form["TextEntered"]);
  

            //  _logger.LogInformation( "hello",Request.Form["translatedText"];

            // Now you can do further processing, such as translation to Leetspeak, and store the result
            // For demonstration, let's simply store the entered text and return the view with the model
            return View("Index", model);
        }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
