using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOLID.OCP.Models;

namespace SOLID.OCP.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShapesService : ControllerBase
    {
        private readonly ShapesService _shapesService;
        public ShapesService(ShapesService shapesService)
        {
            _shapesService = shapesService;
        }

        [HttpGet]
        public void Get(Circle circle)
        {
            _shapesService.Get(circle);
        }
    }
}
