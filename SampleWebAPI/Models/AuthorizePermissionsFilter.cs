namespace SampleWebAPI.Models
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System.Collections.Generic;

    public class AuthorizePermissionsFilter : ActionFilterAttribute, IActionFilter
    {
        public IEnumerable<Permissions> permissionsToAuthorize;

        public AuthorizePermissionsFilter(params Permissions[] permissionsToAuthorize): base()
        {
            this.permissionsToAuthorize = permissionsToAuthorize;
        }

        /// <summary>
        /// This is called before the controller.
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //var authorizationHeaderToken = context.HttpContext.Request.Headers["Authorzation"];
            //var accessToken = SomeHelperClass.ParseAccessTokenFromString(authorizationHeaderToken);
            //var permissions = accessToken.Claims;
            var hasPermission = true;// SomeHelperClass.HasPermission(permissionsToAuthorize, permissions);

            if (!hasPermission)
            {
                var result = new ContentResult() { Content = "{ \"message\":\"Cant touch this\" }", ContentType = "Application/json", StatusCode = 403 };
                context.Result = result;
            }

            base.OnActionExecuting(context);
        }
    }
}
