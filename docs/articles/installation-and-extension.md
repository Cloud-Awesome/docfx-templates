# Installation and extension

## Installation

Installing this template is simple and should only require two steps.

### 1. Include the template in the templates folder

If it doesn't already exist, create a new folder called "templates" at the top level of your documentation directory.

> [!TIP]
> The 'templates/' folder should be at the same level as your docfx.json 

Include the template contents (either zipped or unzipped) as child of the templates folder 

### 2. Reference the template in the docfx.json manifest

In the docfx.json manifest, reference the relative path of the template in the `build/template` section.

If you are using the [Contributors](xref:page-functionality-contributors) functionality or any of the environment settings functions, be sure to reference those files in the `globalMetadataFiles` node too.  

```json
"build": {
    ...
    "template": [
      "templates/cloud-awesome.docfx.liquid-base"
    ],
    "globalMetadataFiles": [ "contributors.json", "environment_settings_liquid_base" ]
    ...
  }
```


> [!IMPORTANT]
> This template is intended as a replacement of the default docfx template, not an extension. Therefore you don't need to include both the default and this template, just this one.
>
> Therefore, `"default", "templates/cloud-awesome.docfx.liquid-base"`, as is often referenced in the official documentation, is superfluous and may result in unexpected behaviour.

## Extension

While this template can be used as is, it has been left in a way that should easily allow for further extension, either in the functionality available, in the styling, or both.

To extend the template further, you should reference an unzipped template file (at least during development).

Any [feedback](https://github.com/Cloud-Awesome/docfx-templates/issues) and/or pull requests are greatly appreciated if they can help others (and me!) consuming the templates.
