using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarPost.LinkedIn.Client.Configuration;

namespace StarPost.LinkedIn.Client
{

    public class LinkedInClient
    {
        private readonly LinkedInConfiguration _configuration;

        public LinkedInClient(LinkedInConfiguration configuration)
        {
            _configuration = configuration;
        }


        public Task<GetAuthorizationCodeResponse> GetAuthorizationCode()
        {
            return Task.FromResult(new GetAuthorizationCodeResponse());
        }
    }

    public class GetAuthorizationCodeResponse
    {
        public string Code { get; set; }
        public string State { get; set; }
    }
}
