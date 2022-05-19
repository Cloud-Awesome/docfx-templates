---
leadParagraph: |
    <p>These templates are extensions to the <a href="https://dotnet.github.io/docfx/">DocFx</a> documentation engine developed by Microsoft.</p>
    <p>They have been created both to extend the functionality available but also to facilitate further extension by replacing all moustache templates with liquid.</p>
---

# DocFX Templates

The templates below all contain exactly the same content, but with different styling.

View any one of them for documentation on how to use the extended functionality, or a specific one to see you a specific page is styled differently

They all also contain PDF templates on top of the web templates. In cases such as the govuk, extensive artistic licence has been taken (and little to no user testing). The primary aim has been a functional facsimile ;)   

## [Liquid Base](/samples/liquid-base/index.html)

A port of the DocFX default template, with little to no styling changes, but with all the moustache templates ripped out and replaced with liquid templates.

This is a good starter template if you want a template with all the hideous moustache templates exorcised but want to implement your own styling.

## [GOVUK](/samples/govuk/index.html)

The liquid base port using the styling from the gov.uk frontend design system.

As far as possible I've respected the gds design system but where patterns didn't exist for the functionality, I've tried to remain as faithful to the spirit of GDS as possible. Feel free to use as much or as little as you like and remember that these templates are meant as a base for further development if you want to change anything.

Feedback is always welcome, **especially** if it is based on any good user research!! 

## [Cloud Awesome](/samples/cloud-awesome/index.html)

An extension of the above two templates, but with my colour palette. 

Feel free to nab it and customise further. The colour palette and other changes on top of the gov.uk design system are all in the SCSS files inheriting from gov.uk, and should therefore be fairly straightforward to alter for your requirements.   