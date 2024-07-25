using CsvReader.Repo;
using CsvReader.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiReader.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRepo _sqlRepo;

        public TipController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _sqlRepo = new SqlRepo();
        }


        [HttpGet(Name = "tips")]
        public IEnumerable<Tip> GetAllTips()
        {
            return _sqlRepo.GetAllTips();
        }

        [HttpGet("tip/{id}")]
        public ActionResult<Tip> GetTipById(int id)
        {
            return _sqlRepo.GetTipById(id);
        }

        // SaveTip(Tip tip)

        // DeleteTipById(int id)

        // DeleteAllTips()


        // public VVV LoadTipsFromFile()
    }
}