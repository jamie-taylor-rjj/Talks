# Advice

A talk originally delivered to students of Notre-Dame Sixth Form College, Leeds studying Digital T-Levels in digital technologies - including media production and software development.

This talk uses the [Takahasi method](https://en.wikipedia.org/wiki/Takahashi_method), and is based on [Trikita's Slide](https://github.com/trikita/slide-html) repo.

## Building and Running

To build this talk... well, it's a single HTML file. And is already build.

To run this talk, open the [slide.html](./slide.html) file in a browser or [view it online](http://htmlpreview.github.io/?https://github.com/jamie-taylor-rjj/Talks/blob/main/advice/slide.html)

## Licence

This talk uses the same license as the outer repo: [![License: CC BY-SA 4.0](https://licensebuttons.net/l/by-sa/4.0/80x15.png)](https://creativecommons.org/licenses/by-sa/4.0/) [Creative Commons Attribution 4.0 International](https://choosealicense.com/licenses/cc-by-4.0/)

## Security

WAT! It's a slide deck. Relax.

Ok, so since this is meant to be a single HTML file for giving talks there's almost no thought gone into the security of the HTML file. But since the HTML slide deck only makes calls out to Google for fonts, I can't see how it could be seen as a _huge_ security issue. There are some inline styles (which can cause issues with [CSP]()), but that shouldn't be something to worry about for this... unless some malicious actor makes some changes to the file and adds some external JavaScript, or embeds it in a frame.

But if someone does that, then you'll have slightly bigger problems.

As with all code you find on the web, read through it and make sure that you [grok](https://en.wikipedia.org/wiki/Grok) what it's doing before running it. 
