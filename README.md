# csharp-hotreload

An example to show hot reloading C# classlibs without restarting the host
application.

`dllToImport` is a class library that I've compiled with different responses for
GetString() (`Test` and `Test2`) respectively.

Upon running (`dotnet run`) the loader application, it will load the dll from
`src/dllToImport/out`. After hitting enter, it will load the
`src/dllToImport/out2`. It will continue to swap between them as you hit enter.
