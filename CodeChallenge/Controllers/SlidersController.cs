using Microsoft.AspNetCore.Mvc;

namespace CodeChallenge.Controllers
{
    public class SliderDto
    {
        public string Path { get; set; }

        public string Title { get; set; }
    }

    public class SlidersController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new List<SliderDto>()
            {
                new SliderDto()
                {
                    Path="1.jpg",
                    Title="Titlee"
                }
            });
        }
    }
}
