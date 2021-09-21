using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LongestIncSubseqApi.Controllers
{
    public class LongestIncSubseqController : Controller
    {
        private readonly ILogger<LongestIncSubseqController> _logger;
        
        public LongestIncSubseqController()
        {
        }

        public LongestIncSubseqController(ILogger<LongestIncSubseqController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public string GetLongestIncSubseq([FromBody] string inputValues)
        {
           
            LongestIncSubseq objLongIncSubseq = new LongestIncSubseq();
            Regex rgx = new Regex(@"^[\d\s]+$");


            if (!String.IsNullOrEmpty(inputValues) && rgx.IsMatch(inputValues))
            {
                objLongIncSubseq.LISFlow(inputValues);

            }
            else
            {

            }
            return objLongIncSubseq.output;
        }
    }
}

    

