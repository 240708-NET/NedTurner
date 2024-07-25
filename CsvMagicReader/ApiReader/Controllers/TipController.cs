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

        public TipController(ILogger<WeatherForecastController> logger, IRepo repo)
        {
            _logger = logger;
            _sqlRepo = repo;
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

        [HttpDelete("tip/{id}")]
        public ActionResult<bool> DeleteTipById(int id)
        {
            return _sqlRepo.DeleteTipById(id);
        }


        [HttpDelete("tips")]
        public ActionResult<bool> DeleteAllTips()
        {
            _sqlRepo.DeleteAllTips();
            return true;
        }


        // [HttpPost("tips")]
        // public IEnumerable<Tip> LoadTipsFromFile()
        // {
        //     return _sqlRepo.L
        // }



        // public VVV SaveTipsToFile()
    }
}