using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;


namespace Models.Refit
{
    public class AuthenticatedHttpClientHandler : HttpClientHandler
    {
        string _token;

        public AuthenticatedHttpClientHandler(string token)
        {
            if (string.IsNullOrEmpty(token)) throw new ArgumentNullException("token is null or empty");
            _token = token;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // See if the request has an authorize header
            var auth = request.Headers.Authorization;
            if (auth != null)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(auth.Scheme, _token);
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
