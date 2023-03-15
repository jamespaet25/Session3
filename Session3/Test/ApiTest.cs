using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session3Api.DataModels;

namespace Session3Api.Test
{
    public class ApiTest
    {
        public RestClient RestClient { get; set; }
        public PetModel PetDetails { get; set; }

        [TestInitialize]
        public void Initialize() 
        {
            RestClient = new RestClient();
        }
    }
}
