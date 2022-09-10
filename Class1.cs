using MonoDevelop.Components;

namespace ExamplePad;
public class Class1 : MonoDevelop.Ide.Gui.PadContent
{
    public override Control Control
    { 
        get {
            MonoDevelop.Core.LoggingService.LogInfo($"Loaded ExamplePad v{VersionInfo.Version}");
            var label = new NSTextField();
            label.StringValue = "Hello World!";
            return label;
        }
    }
}

