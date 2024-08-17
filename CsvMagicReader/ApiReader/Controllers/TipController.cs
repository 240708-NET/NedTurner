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


        [HttpGet("tips")]
        public IEnumerable<Tip> GetAllTips()
        {
            return _sqlRepo.GetAllTips();
        }

        [HttpGet("tip/{id}")]
        public ActionResult<Tip> GetTipById(int id)
        {
            return _sqlRepo.GetTipById(id);
        }
        
        [HttpGet("tip/order{id}")]
        public ActionResult<Tip> GetTipOrderById(int id)
        {
            return _sqlRepo.GetTipByOrderId(id);
        }

        [HttpPost]
        public Tip SaveTip([FromBody] Tip newTip)
        {
            try
            {
                _sqlRepo.SaveTip(newTip);
                var tips = _sqlRepo.GetAllTips();
                var tip =  from t in tips
                    where newTip.order_id == t.order_id
                    select t;
                return tip.First();
            }
            catch
            {
                return new Tip();
            }
        }

        [HttpDelete("tip/{id}")]
        public ActionResult<bool> DeleteTipById(int id)
        {
            return _sqlRepo.DeleteTipById(id);
        }
        [HttpDelete("tip/order{id}")]
        public ActionResult<bool> DeleteTipByOrderId(int id)
        {
            return _sqlRepo.DeleteTipByOrderId(id);
        }


        [HttpDelete("tips")]
        public ActionResult<bool> DeleteAllTips()
        {
            _sqlRepo.DeleteAllTips();
            return true;
        }


        [HttpPost("tips/load")]
        public IEnumerable<Tip> LoadTipsFromFile()
        {
            return _sqlRepo.LoadTipsFromFile();
        }



        // public VVV SaveTipsToFile()
    }
}