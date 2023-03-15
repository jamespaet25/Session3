using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Session3Api.DataModels;

namespace Session3Api.Test.TestData
{
    public class GeneratePet
    {
        public static PetModel PetUser()
        {
            return new PetModel()
            {
                Id = 9876,
                Category = new Category()
                {
                    Id = 1,
                    Name = "Snoopy"
                },
                Name = "Snoopy",
                PhotoUrls = new List<string>
                {
                    "Pogi"
                },
                Tags = new List<Category>()
                {
                    new Category()
                {
                    Id = 0,
                    Name = "Snoopy"
                }
                },
                Status = "available"
            };
        }

    }
}
