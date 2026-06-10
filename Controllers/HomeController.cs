using Microsoft.AspNetCore.Mvc;
using Teleprompter.Models;

namespace Teleprompter.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Teleprompter()
    {
        var model = new TeleprompterModel
        {
            Text = "Enter your script here..."
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult SaveScript([FromBody] TeleprompterModel model)
    {
        if (string.IsNullOrEmpty(model.Text))
        {
            return BadRequest("Script text cannot be empty");
        }

        // In a real app, save to database
        return Ok(new { message = "Script saved successfully" });
    }
}
