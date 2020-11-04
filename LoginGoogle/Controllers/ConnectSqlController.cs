using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using LoginGoogle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace LoginGoogle.Controllers
{
    public class ConnectSqlController : Controller
    {
        public IActionResult Index()
        {
            User u = new User();
            string conn = configuration.GetConnectionString("MyConnectionStrings");
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from UserLogin",connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
            }
            connect.Close();
            return Json(u);
        }
        private readonly IConfiguration configuration;
        public ConnectSqlController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }
}
