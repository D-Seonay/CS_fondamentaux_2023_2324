using Geometrie.DTO;
using Geometrie.Services;
using Microsoft.AspNetCore.Mvc;

namespace Geometrie.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PointController : ControllerBase
    {
        private readonly ILogger<PointController> _logger;
        private Point_Service _pointService;
        
        public PointController(ILogger<PointController> logger, Point_Service pointService)
        {
            _logger = logger;
            _pointService = pointService;
        }

        [HttpGet]
        public Point_DTO GetById(int id)
        {
            return _pointService.GetById(id);

        }
    }
}
