using OwaspHeaders.Core.Extensions;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// app.UseSecureHeadersMiddleware();

// app.Use(async (context, next) =>
// {
//     context.Response.Headers.Append("X-Frame-Options", "DENY");
//     context.Response.Headers.Append("X-Content-Type-Options", "nosniff");
//     context.Response.Headers.Append("Strict-Transport-Security",
//         "max-age=31536000; includeSubDomains");
//     context.Response.Headers.Append("Referrer-Policy",
//         "strict-origin-when-cross-origin");
//     // Comment: "And we need at least 4 more headers..."
//     await next();
// });

app.MapGet("/", () => "Hello World!");

// app.MapGet("/", (HttpContext httpContext) =>
// {
//     var headerValues = httpContext.Response.Headers.Select(h => $"{h.Key}: {h.Value}").ToArray();
//     var response = new
//     {
//         message = "SecureHeaders middleware applied successfully!",
//         headers = headerValues,
//         loggingInfo = new
//         {
//             note = "Check console output for SecureHeaders logging with Event IDs 1001-1005",
//             eventIds = new
//             {
//                 middlewareInitialized = 1001,
//                 headersAdded = 1002,
//                 requestIgnored = 1003,
//                 headersGenerated = 1004,
//                 headerAdded = 1005
//             }
//         }
//     };

//     return response;
// });

app.Run();
