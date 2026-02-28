using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillAidePOC.Models;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WillAidePOC.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration) {
            _configuration = configuration;
        }


        [HttpGet]
        [Route("GetUsers")]
        public JsonResult GetUserData()
        {
            DBHelper obj = new DBHelper(_configuration);
            var res = obj.GetUserDetailsAndNominees();
            return new JsonResult(res);           
        }

    }
}
