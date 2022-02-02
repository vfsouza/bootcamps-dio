using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace api_cicd.Controllers;

[ApiController]
[Route("[controller]")]
public class CatController : ControllerBase
{
   public static string URLBase = "asd";
   private readonly ILogger<CatController> _logger;
   private readonly IConfiguration Configuration;
   public CatController(ILogger<CatController> logger, IConfiguration configuration) {
      _logger = logger;
      Configuration = configuration;
   }
   [HttpGet]
   public IActionResult Get(bool image) {
      Random random = new Random();
      string url = URLBase + random.Next(1, 10) + ".jpg";

      if (image) {
         using (var webClient = new WebClient()) {
            byte[] imageBytes = webClient.DownloadData(url);
            return File(imageBytes, "image/jpg");
         }
      } else {
         return Ok(url);
      }
   }
}
