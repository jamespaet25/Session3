using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Api.Resources
{
    public class Endpoints
    {
        // Base URL
        private static readonly string BaseURL = "https://petstore.swagger.io/v2";

        public static string GetPetById(string Id) => $"{BaseURL}/pet/{Id}";

        public static string PostPet() => $"{BaseURL}/pet/";

        public static string DeletePetById(string Id) => $"{BaseURL}/pet/{Id}";

    }
}
