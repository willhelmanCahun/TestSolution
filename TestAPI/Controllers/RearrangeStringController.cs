using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using test.application.Services;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RearrangeStringController : ControllerBase
    {
       
        public RearrangeStringController( )
        {
            
        }

        [HttpPost]
        public IEnumerable<string> RearrangeString(string individuals, string order) {
            StringAnalyzer stringAnalyzer= new StringAnalyzer();
            string[] results;
            try
            {
                 results = stringAnalyzer.ReArrangeString(individuals.Split(","), order.Split(","));

            }
            catch (Exception ex) {
                results = new string[1];
                results[0] = ex.Message;
            }
            return results;
        }
    }
}
