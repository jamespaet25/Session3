using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Session3Api.DataModels;
using Session3Api.Helpers;
using Session3Api.Resources;
using Session3Api.Test.TestData;

[assembly: Parallelize(Workers = 10, Scope = ExecutionScope.MethodLevel)]
namespace Session3Api.Test
{
    [TestClass]
    public class GetOnly : ApiTest
    {
        private readonly List<PetModel> cleanUpList = new List<PetModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            PetDetails = await UserHelpers.AddNewPet(RestClient);
        }

        [TestMethod]
        public async Task GetProject()
        {
            // Arrange
            var getRestRquest = new RestRequest(Endpoints.GetPetById(PetDetails.Id.ToString()));
            cleanUpList.Add(PetDetails);

            // Act
            var getRestResponse = await RestClient.ExecuteGetAsync<PetModel>(getRestRquest);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, getRestResponse.StatusCode, "Status Code is not equal to 200");
            Assert.AreEqual(PetDetails.Name, getRestResponse.Data.Name);
            Assert.AreEqual(PetDetails.Category.Name, getRestResponse.Data.Category.Name);
            Assert.AreEqual(PetDetails.PhotoUrls[0], getRestResponse.Data.PhotoUrls[0]);
            Assert.AreEqual(PetDetails.Tags[0].Name, getRestResponse.Data.Tags[0].Name);
            Assert.AreEqual(PetDetails.Status, getRestResponse.Data.Status);

        }
            [TestCleanup]
             public async Task TestCleanUp()
            {
                foreach (var data in cleanUpList)
                {
                    var restRequest = new RestRequest(Endpoints.GetPetById(data.Id.ToString()));
                    var restResponse = await RestClient.DeleteAsync(restRequest);
                }
      
            }

     }
}
