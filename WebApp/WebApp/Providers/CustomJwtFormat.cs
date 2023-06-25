using Microsoft.Owin.Security;
using System;

namespace WebApp.Providers
{
    public class CustomJwtFormat : ISecureDataFormat<AuthenticationTicket>
    {
        private readonly string _issuer = string.Empty;
        public CustomJwtFormat(string issuer)
        {
            _issuer = issuer;
        }
        public string Protect(AuthenticationTicket data)
        {
            throw new NotImplementedException();
        }
        public AuthenticationTicket Unprotect(string protectedText)
        {
            throw new NotImplementedException();
        }
    }
}