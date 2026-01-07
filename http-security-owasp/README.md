# Unlocking HTTP Security Nirvana: Zero to Hero in 45 Minutes

A talk on HTTP security via HTTP headers, as per [OWASP's Secure Headers Project](https://owasp.org/www-project-secure-headers/). It also includes examples from my [OwaspHeaders.Core NuGet package](https://gaprogman.github.io/OwaspHeaders.Core/).

> [!NOTE]
> The NuGet package is specific to ASP .NET Core applications, but the details of HTTP headers for security are technology agnostic.

This talk originally used the [Takahasi method](https://en.wikipedia.org/wiki/Takahashi_method). However, each slide quickly became bigger and bigger. The dream is to include 1-4 words per slide and refer to the notes (provided as HTML comments) within each slide. But I'm not that good at presenting 😕

The repo layout, and contents of slide.html, are based on [Trikita's Slide](https://github.com/trikita/slide-html) repo.

## Sources / Inspiration

The main sources & inspirations for this talk are:

- [OWASP's Secure Headers Project](https://owasp.org/www-project-secure-headers/)

## Building and Running

To build this talk... well, it's a single HTML file (with separate CSS and JS files). And is already built.

To run this talk, open the [slide.html](./slide.html) file in a browser or [view it online](https://htmlpreview.github.io/?https://github.com/jamie-taylor-rjj/Talks/blob/main/http-security-owasp/slide.html#0).

Or you could use [VS Code](https://code.visualstudio.com/) and the [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer) extension.

### VS Code & Live Server

In preparing this slide deck, I used VS Code and an extension called [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer). There are no build requirements for this slide deck.

Open the root of the repository with a live server and head to the url exposed by the server:

- Open the repository with VS Code
- Open the [command palette](https://code.visualstudio.com/docs/getstarted/userinterface#_command-palette)
- Type `> Live Server: Open with Server`
- A browser window should open with the slide deck running

Don't forget to stop the Live Server when you are done:

- Open the [command palette](https://code.visualstudio.com/docs/getstarted/userinterface#_command-palette)
- Type `> Live Server: Stop Live Server`

> [!WARNING]
> Not stopping the live server could lead to memory leaks. Not to mention an exposed port on your computer.

## Links

The following links were originally in the talk, but I've taken them out. I'll leave them here for those who want ot learn more about the subject.

- https://owasp.org/www-project-secure-headers: OWASP's Secure Headers Project
- https://gaprogman.github.io/OwaspHeaders.Core: OwaspHeaders.Core NuGet package
- https://gaprogman.github.io/OwaspHeaders.Core/llms-full.txt: LLM friendly documentation for OwaspHeaders.Core

## Who is this Jamie chap?

Jamie is the host of [The Modern .NET Show](https://dotnetcore.show/), main developer/contributor on [OwaspHeaders.Core](https://gaprogman.github.io/OwaspHeaders.Core/), [Microsoft MVP](https://mvp.microsoft.com/en-US/mvp/profile/0ff8fe6a-4b4c-ec11-8f8e-00224827f7fc), and Strategic Technology Consultant at [RJJ Software](https://rjj-software.co.uk/).

## Licence

This talk uses the same license as the outer repo: [![License: CC BY-SA 4.0](https://licensebuttons.net/l/by-sa/4.0/80x15.png)](https://creativecommons.org/licenses/by-sa/4.0/) [Creative Commons Attribution 4.0 International](https://choosealicense.com/licenses/cc-by-4.0/)

## Security

WAT! It's a slide deck. Relax.

Ok, so since this is meant to be a single HTML file for giving talks there's almost no thought gone into the security of the HTML file. But since the HTML slide deck only makes calls out to Google for fonts, I can't see how it could be seen as a _huge_ security issue.

An earlier version of this slide deck had inline styles and JS(which can cause issues with [CSP](https://developer.mozilla.org/en-US/docs/Web/HTTP/CSP)). However, even with separate files there is still the possibility that a malicious actor could alter the JS or CSS through a commit pushed to the original repo.

But if someone does that, then you'll have slightly bigger problems.

As with all code you find on the web, read through it and make sure that you [grok](https://en.wikipedia.org/wiki/Grok) what it's doing before running it.
