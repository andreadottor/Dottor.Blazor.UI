# Dottor.Blazor.UI

A collection of component for Blazor:

- FormSubmitButton
- InputTextOnInput
- Tabs
- MessageBox (alert, confirm)
- Modal

## Prerequisities

The library use Bootstrap 5 for Styles and JavaScript.


## Getting started

### Install the package

```dotnetcli
dotnet add package Dottor.Blazor.UI --version 0.0.1-alpha
```

### Add the namespace

Add the following to _Imports.razor

```razor
@using Dottor.Blazor.UI
@using Dottor.Blazor.UI.Services
```

### Add global components

Add the following to the MainLayout.razor or App.razor

```razor
<MessageBox />
```

### Register Services

Add the following to the relevant sections of Program.cs

```cs
using Dottor.Blazor.UI
```

```cs
builder.Services.AddDottorUI();
```

## Usage

All of the sample code can be found in the `samples` folder.

### Tabs

```razor
<Tabs>
    <TabPanel Title="Tab 1">
        <h2>Titolo tab 1</h2>
        <p>Descrizione tab 1</p>
    </TabPanel>
    <TabPanel Title="Tab 2">
        <h2>Titolo tab 2</h2>
        <p>Descrizione tab 2</p>
    </TabPanel>
    <TabPanel Title="Tab 3">
        <h2>Titolo tab 3</h2>
        <p>Descrizione tab 3</p>
    </TabPanel>
</Tabs>
```

### FormSubmitButton

```razor
<EditForm Model="this" OnValidSubmit="Save">
    <DataAnnotationsValidator />
    ...
    <FormSubmitButton>Save</FormSubmitButton>
</EditForm>
```