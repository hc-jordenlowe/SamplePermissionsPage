For .net, permissions attribute is very similar to Angular.

First, check out the Models/AuthorizePermissionsFilter.cs

This filter runs as part of ASP.net Web API's workflow.  Considering we have access to the httpContext, we will have access to the access token.  There we will need to parse it and pull out the claims that need to be checked against our permissions.

For a demo, the action that has the AuthorizePermissionsFilter attribute is the WeatherForecasts.

For angular, be sure to check out the README.md there to see how to do the same thing in the front end with permissions.