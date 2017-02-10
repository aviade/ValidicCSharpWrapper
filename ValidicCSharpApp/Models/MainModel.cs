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
                    OrganizationId = "51aca5a06dedda916400002b",
                    AccessToken = "ENTERPRISE_KEY"
                },
            };
        }
    }
}
