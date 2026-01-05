# Demo App Steps

1. `dotnet run` as is
1. Open dev tools -> no headers present
1. Uncomment `app.Use(async (context, next) =>` block (line 9 onwards)
1. Restart app, open dev tools -> some headers present
1. Comment out `app.Use(async (context, next) =>` block (line 9 onwards)
1. Comment out `app.MapGet("/", () => "Hello World!");` (line 21)
1. Uncomment Middleware statement (`app.UseSecureHeadersMiddleware();` - line 7)
1. Uncomment `// app.MapGet("/", (HttpContext httpContext) =>` (line line 21)
1. Restart app, open dev tools -> all headers present

## TODO

Need a part of the demo using CSP
