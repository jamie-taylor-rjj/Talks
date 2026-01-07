using OwaspHeaders.Core.Enums;
using OwaspHeaders.Core.Extensions;
using OwaspHeaders.Core.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

#region custom middleware
// app.Use(async (context, next) =>
// {
//     context.Response.Headers.Append("X-Frame-Options", "DENY");
//     context.Response.Headers.Append("X-Content-Type-Options", "nosniff");
//     context.Response.Headers.Append("Strict-Transport-Security",
//         "max-age=31536000; includeSubDomains");
//     context.Response.Headers.Append("Referrer-Policy",
//         "strict-origin-when-cross-origin");
//     context.Response.Headers.Append("Jamie", "DENY");
//     // And we need at least 4 more headers...
//     await next();
// });
#endregion

#region NuGet Middleware
// app.UseSecureHeadersMiddleware();
#endregion

#region NuGet Middleware with complex CSP
// app.UseSecureHeadersMiddleware(Helpers.GenerateOwaspHomePageCsp());
#endregion

app.MapGet("/", (HttpContext httpContext) =>
{
    var headerValues
        = httpContext.Response.Headers.Select(h => $"{h.Key}: {h.Value}").ToArray();
    var response = new
    {
        message = headerValues.Any() ? "Secure headers applied successfully! 👌😎🆒" : "No secure headers 😭",
        headers = headerValues
    };

    return response;
});

app.Run();

#region helpers
public static class Helpers
{
        public static SecureHeadersMiddlewareConfiguration GenerateOwaspHomePageCsp() =>
        SecureHeadersMiddlewareExtensions.BuildDefaultConfiguration()
            .UseContentSecurityPolicy()
            .SetCspUris(
            [
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "self" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://api.github.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.githubusercontent.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.google-analytics.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://owaspadmin.azurewebsites.net" },

                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.twimg.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://platform.twitter.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://www.youtube.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.doubleclick.net" }
            ], CspUriType.DefaultUri)
            .SetCspUris(
            [
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "self" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://api.github.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.githubusercontent.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.google-analytics.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://owaspadmin.azurewebsites.net" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.twimg.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://platform.twitter.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://www.youtube.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.doubleclick.net" }
            ], CspUriType.FrameAncestors)
            .SetCspUris(
            [
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.vuejs.org" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.stripe.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.wufoo.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.sched.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.google.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.twitter.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://www.youtube.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://w.soundcloud.com" }
            ], CspUriType.Frame)
            .SetCspUris(
            [
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "self" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "unsafe-inline" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "unsafe-eval" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://fonts.googleapis.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://app.diagrams.net" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://cdnjs.cloudflare.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://cse.google.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.vuejs.org" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.stripe.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.wufoo.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.youtube.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.meetup.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.sched.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.google-analytics.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://unpkg.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://buttons.github.io" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://www.google.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.gstatic.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.twitter.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.twimg.com" }
            ], CspUriType.Script)
            .SetCspUris(
            [
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "self" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "unsafe-inline" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.gstatic.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://cdnjs.cloudflare.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://www.google.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://fonts.googleapis.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://platform.twitter.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.twimg.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "data:" }
            ], CspUriType.Style)
            .SetCspUris(
            [
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "self" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "fonts.gstatic.com" }
            ], CspUriType.Font)
            .SetCspUris(
            [
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "self" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://pay.google.com" }
            ], CspUriType.Manifest)
            .SetCspUris(
            [
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Directive, DirectiveOrUri = "self" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.globalappsec.org" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "data:" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "www.w3.org" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://licensebuttons.net" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://img.shields.io" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.twitter.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://github.githubassets.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.twimg.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://platform.twitter.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.githubusercontent.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.vercel.app" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.cloudfront.net" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.coreinfrastructure.org" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.securityknowledgeframework.org" },

                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://badges.gitter.im" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://travis-ci.org" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://api.travis-ci.org" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://s3.amazonaws.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://snyk.io" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://coveralls.io" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://requires.io" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://github.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.googleapis.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.google.com" },
                new ContentSecurityPolicyElement { CommandType = CspCommandType.Uri, DirectiveOrUri = "https://*.gstatic.com" }

            ], CspUriType.Img);
#endregion
}