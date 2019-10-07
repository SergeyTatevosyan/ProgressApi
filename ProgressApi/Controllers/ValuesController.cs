using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProgressApi.Models.DBContexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProgressApi.Models;

namespace ProgressApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ProgressContext _context;

        public ValuesController(ProgressContext context)
        {
            _context = context;
            if (_context.PercentProgress.Count() == 0)
            {
                _context.PercentProgress.Add(new PercentProgress (1,50,"FirstCategory", new DateTime(2017,1,1)));
                _context.PercentProgress.Add(new PercentProgress (2, 89, "SecondCategory", new DateTime(2017, 1, 1)));

                _context.PercentProgress.Add(new PercentProgress(3, 30, "FirstCategory", new DateTime(2018, 1, 1)));
                _context.PercentProgress.Add(new PercentProgress(4, 70, "SecondCategory", new DateTime(2018, 1, 1)));
                _context.SaveChanges();
            }

            if (_context.ValuesProgress.Count() == 0)
            {
                _context.ValuesProgress.Add(new ValuesProgress(1, 4, "cat1", new DateTime(2017, 1, 1),10));
                _context.ValuesProgress.Add(new ValuesProgress(2, 2, "cat2", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(3, 7, "cat3", new DateTime(2017, 1, 1), 12));
                _context.ValuesProgress.Add(new ValuesProgress(4, 4, "cat4", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(5, 8, "cat5", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(6, 3, "cat6", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(7, 4, "cat7", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(8, 4, "cat8", new DateTime(2017, 1, 1), 10));

                _context.ValuesProgress.Add(new ValuesProgress(9, 2, "cat1", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(10, 8, "cat2", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(11, 1, "cat3", new DateTime(2017, 1, 1), 12));
                _context.ValuesProgress.Add(new ValuesProgress(12, 6, "cat4", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(13, 8, "cat5", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(14, 3, "cat6", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(15, 9, "cat7", new DateTime(2017, 1, 1), 10));
                _context.ValuesProgress.Add(new ValuesProgress(16, 10, "cat8", new DateTime(2017, 1, 1), 10));
                _context.SaveChanges();
            }
        }
    



        // GET api/values
        [HttpGet]
        public ActionResult GetValuesProgress(DateTime Year)
        {
            var res = new
            {
                data = _context.PercentProgress.Where(perc => perc.Year.Year == Year.Year),
                Title = _context.ValuesProgress.Where(val => val.Year.Year == Year.Year)
            };
            return new ObjectResult(res);
        }



    }
}
