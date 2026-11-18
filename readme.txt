# Vertical Line Counter

This is a Windows console application that counts the number of vertical
black lines.



## How to run

Download the latest Windows x64 ZIP:
https://github.com/danielerhabor/VerticalLineCounter/releases/latest/download/VerticalLineCounter-win-x64.zip

Extract the ZIP. From the extracted folder, run the executable with the
absolute path to your JPEG as its only argument:

```
.\VerticalLineCounter.exe "C:\absolute\path\to\your-image.jpg"
```

Replace the example path with the absolute path to your JPEG image.

## Build, run, and test from source

### Prerequisites

- .NET 10 SDK
- Run `dotnet --version` to check for version 10.0.x.

### Commands

Run these commands from the repository root:

- Build: `dotnet build VerticalLineCounter.slnx`
- Run: `dotnet run --project VerticalLineCounter -- /absolute/path/to/your-image.jpg`
- Test: `dotnet test VerticalLineCounter.slnx`
