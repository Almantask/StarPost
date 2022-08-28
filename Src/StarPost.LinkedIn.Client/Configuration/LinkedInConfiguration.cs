namespace StarPost.LinkedIn.Client.Configuration
{
    /// <summary>
    /// Configuration used for <see cref="LinkedInClient"/>.
    /// </summary>
    public class LinkedInConfiguration
    {
        /// <summary>
        /// <see href="https://docs.microsoft.com/en-us/linkedin/shared/authentication/authorization-code-flow?context=linkedin%2Fcontext&view=li-lms-2022-08&tabs=HTTPS">LinkedIn OAuth2</see> flow related configuration. 
        /// </summary>
        public class OAuth
        {
            /// <summary>
            /// Base Url used for getting access and refresh tokens.
            /// </summary>
            public Uri BaseUrl { get; set; }

            /// <summary>
            /// Client Id
            /// </summary>
            public string ClientId { get; set; }

            /// <summary>
            /// Client Secret. DO NOT STORE AS PLAIN TEXT!
            /// </summary>
            public string ClientSecret { get; set; }
        }

        /// <summary>
        /// API-related configuration section.
        /// </summary>
        public class Api
        {
            /// <summary>
            /// Base Url used for make API calls.
            /// </summary>
            public Uri BaseUrl { get; set; }

            /// <summary>
            /// LinkedIn API version.
            /// </summary>
            public string Version { get; set; }

            /// <summary>
            /// User Agent (what entity makes a call to an API).
            /// </summary>
            public string UserAgent { get; set; }
        }
    }
}