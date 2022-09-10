# ExamplePad
An example how to create a Cocoa based pad for VSMac

![Screenshot of ExamplePad](Screenshot.png)

Running the ExamplePad project should launch a new instance of VSMac with the addin loaded.

If this doesn't work the first time, try running

```sh
dotnet msbuild *.csproj /t:InstallAddin
```

This will generate the mpack file in the bin folder as well as attempt to load it into VSMac.
