using System;
using System.Xml.Linq;
using Mono.Addins;
using Mono.Addins.Description;


[assembly: Addin(
"ExamplePad",
    Namespace = "ExamplePad",
    Version = VersionInfo.Version
)]

[assembly: AddinName("ExamplePad")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinUrl("https://whatever")] //
[assembly: AddinDescription("My first extension")]
[assembly: AddinAuthor("Jason Imison")]

public static class VersionInfo
{ 
    public const string Version = "0.0.0.1";
}
