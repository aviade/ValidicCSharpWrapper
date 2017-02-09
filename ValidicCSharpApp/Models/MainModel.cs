using System.Collections.Generic;
using ValidicCSharp.Model;

namespace ValidicCSharpApp.Models
{
    public class MainModel
    {
        public List<OrganizationAuthenticationCredentials> OrganizationAuthenticationCredentials { get; set; }

        public void Populate()
        {
            OrganizationAuthenticationCredentials = new List<OrganizationAuthenticationCredentials>
            {
                new OrganizationAuthenticationCredentials
                {
                    OrganizationId = "55dcc3a9623865001100000b",
                    AccessToken = "b1406efd1f8b50fb1190a3faa751a73a73838c7cc6012ba3119bead30f9596da"
                },
            };
        }
    }
}