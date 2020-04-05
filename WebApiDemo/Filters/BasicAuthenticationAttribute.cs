using EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiDemo.Filters
{
    /// <summary>
    /// filter for basic authentication.
    /// this attribute can be applied on any controller , action, or globally on all api controller
    /// </summary>
    public class BasicAuthenticationAttribute: AuthorizationFilterAttribute
    {
        // HttpActionContext has access to both request and response. so in basic authentication
        // client send authentication in header. so we check for Authorization header of context.
        // if it is null it means unauthorised request.
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            // as no authorization header present so it is considered as unauthorized.
            if(actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                // here we will get uname pass as base 64 encoded : username:pass
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;

                // we need to decode base 64 as it is in base64encoded. // this will return decoded string.
                string DecodedAuthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));

                // now we have uid pass in format of colon so need to split with colon (UID:PASS)
                string[] usernamepassARRAY = DecodedAuthenticationToken.Split(':');

                string username = usernamepassARRAY[0];
                string password = usernamepassARRAY[1];

                if(EmployeeSecurity.Login(username, password)) {

                    // setting principle of current thread if login success.
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }


            }
        }
    }
}