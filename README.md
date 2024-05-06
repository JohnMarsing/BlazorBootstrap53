# Blazor .net 8 and Bootstrap 5.3

#### Screen Shot
![ReadmeScreenshot](https://github.com/JohnMarsing/BlazorBootstrap53/assets/1078267/06e9a51b-ae6b-4ee0-a29f-adc898dadcbf)

This repo demonstrates examples of how I use Blazor and Bootstrap 5.3
- This was receently update from a .Net 7 Server Side  Blazor App to .Net 8 Blazor Web App.
- I used Jon Hilton's [blog](https://jonhilton.net/blazor-net8-migration/) to guide me.

# Nuget Packages Used
- `Ardalis.SmartEnum`
- `Blazored.Toast`
- `Serilog`
- `Seq`

# Features

## Bootstrap
- Using Bootstrap `offcanvas` to show messaging like if an error occured
- Using a Bootstrap Modal for the user to select QRC

## Vertical Slice Archictecture
- I really like how this approach along with Blazor's component model brings great development clarity 😀
- All UI pages, includeing the Home Page are under the `Features` folder

## "Meta" Programming
- Extensive use of the SmartEnum to capture meta data to help drive the Navigation and  `Sitemap.razor` and `Footer.razor`.

## Blazored Components
- Using `Blazored.Toast` to show messaging like if an error occured

## Logging
I used extensive logging in `Program.cs`
