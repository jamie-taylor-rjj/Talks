# Empathy, Sympathy & Compassion

A talk on Empathy, Sympathy, and Compassion; originally given at [Umbtraco In The City 2025]() - which took place online in Manchester (UK), on November 7th, 2025.

This talk originally used the [Takahasi method](https://en.wikipedia.org/wiki/Takahashi_method). However, each slide quickly became bigger and bigger. The dream is to include 1-4 words per slide and refer to the notes (provided as HTML comments) within each slide. But I'm not that good at presenting 😕

The repo layout, and contents of slide.html, are based on [Trikita's Slide](https://github.com/trikita/slide-html) repo.

## Sources / Inspiration

The main sources & inspirations for this talk are:

- [The Good Place](https://en.wikipedia.org/wiki/The_Good_Place) - which acted as partial inspiration
- [The Friendly Orange Glow](https://app.thestorygraph.com/books/df551411-3031-411e-937c-1587da0a60ca/) - the other source of inspiration
  - [Official website](http://friendlyorangeglow.com)
- [Hackers: Heroes of the Computer Revolution](https://app.thestorygraph.com/books/3e48b2b6-1993-4cb4-b24e-9b737c980f4d)
- [Nasty, Brutish, and Short](https://app.thestorygraph.com/books/ab3810a4-6d87-42c2-bf26-1350c3cc99a1) by by Scott Hershovitz
- The work of Brené Brown
- A number of my previous clients
- Several conversations I had for The Modern .NET Show:
  - [with Dylan Beattie](https://dotnetcore.show/episode-48-rockstar-with-dylan-beatie/)
  - [with Safia Abdalla](https://dotnetcore.show/season-8/compassionate-coding-safia-abdallas-insights-on-empathy-in-open-source-development/)
- A [blog post that I wrote on the subject](https://rjj-software.co.uk/blog/important-skills-for-developers-empathy/) (can I be my own source?)
- [Episode 208](https://open.spotify.com/episode/25ifQbR73ybIZKW7AiU7yd) of Tabs & Spaces
- Several videos on the subject:
  - [Brené Brown on Empathy](https://www.youtube.com/watch?v=35Wt8LhoVHA)
  - [Pych2Go on Empathy vs Sympathy](https://www.youtube.com/watch?v=1Evwgu369Jw)
  - [Simon Sinek on Understanding Sympathy](https://www.youtube.com/watch?v=pi86Nr9Mdms)

## Building and Running

To build this talk... well, it's a single HTML file (with separate CSS and JS files). And is already built.

To run this talk, open the [slide.html](./slide.html) file in a browser or [view it online](http://htmlpreview.github.io/?https://github.com/jamie-taylor-rjj/Talks/blob/main/uitc-empathy-sympathy-compassion/slide.html).

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

## TODO

The following are TODO items:

- Read through talk and update with new ideas and points
- Update links on second slide (short links to repo and viewing the slides in browser)

## Licence

This talk uses the same license as the outer repo: [![License: CC BY-SA 4.0](https://licensebuttons.net/l/by-sa/4.0/80x15.png)](https://creativecommons.org/licenses/by-sa/4.0/) [Creative Commons Attribution 4.0 International](https://choosealicense.com/licenses/cc-by-4.0/)

## Security

WAT! It's a slide deck. Relax.

Ok, so since this is meant to be a single HTML file for giving talks there's almost no thought gone into the security of the HTML file. But since the HTML slide deck only makes calls out to Google for fonts, I can't see how it could be seen as a _huge_ security issue.

An earlier version of this slide deck had inline styles and JS(which can cause issues with [CSP](https://developer.mozilla.org/en-US/docs/Web/HTTP/CSP)). However, even with separate files there is still the possibility that a malicious actor could alter the JS or CSS through a commit pushed to the original repo.

But if someone does that, then you'll have slightly bigger problems.

As with all code you find on the web, read through it and make sure that you [grok](https://en.wikipedia.org/wiki/Grok) what it's doing before running it.
