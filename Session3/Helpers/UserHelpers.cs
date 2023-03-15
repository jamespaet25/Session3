using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session3Api.DataModels;
using Session3Api.Test.TestData;
using Session3Api.Resources;
using System.Security.Claims;


namespace Session3Api.Helpers
{
    /// <summary>
    /// Class Containing all methods for Pets
    /// </summary>
    public class UserHelpers
    {
        /// <summary
        /// Send a Post to add new Pet
        /// </summary
        /// <param name ="client">Rest Client</param>
        /// <returns>Created Pet Data</returns>

        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newPetData = GeneratePet.PetUser();
            var postRequest = new RestRequest(Endpoints.PostPet());

            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.PostAsync(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
