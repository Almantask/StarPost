using StarPost.LinkedIn.Client;
using StarPost.LinkedIn.Client.Configuration;
using StarPost.Tests.Common.Assertions;

namespace StarPost.Integrations.LinkedIn.Tests
{
    public class LinkedInClientTests
    {
        private readonly LinkedInClient _client;

        private readonly LinkedInConfiguration _configuration;

        public LinkedInClientTests()
        {
            _configuration = new LinkedInConfiguration();
            _client = new LinkedInClient(_configuration);
        }

        [Fact]
        public async Task GetAuthorizationCode_WhenRecognizedClientIdAndSecret_ReturnsCodeAndState()
        {
            var expectedResponse = new object();

            var response = await _client.GetAuthorizationCode();

            response.Should().MatchProvidedPropertiesOf(expectedResponse);
        }

        [Fact]
        public void GetAccessToken_WhenNonExpiredAuthorizationCode_ReturnsToken()
        {

        }
    }
}