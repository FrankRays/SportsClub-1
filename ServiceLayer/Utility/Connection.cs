using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Utility
{
    class Connection
    {
        public static string ConnectionString()
        {
           return ConfigurationManager.AppSettings["sqlConnectionString"].ToString();
        }
    }
}
