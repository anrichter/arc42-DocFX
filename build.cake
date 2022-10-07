///////////////////////////////////////////////////////////////////////////////
// Addins
///////////////////////////////////////////////////////////////////////////////

#addin "Cake.DocFx&Version=1.0.0"
#tool "docfx.console&Version=2.59.4"
#tool "DocFx.Plugins.PlantUml&Version=1.1.24"

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "DocFX-Serve");

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Clean")
    .Description("Cleanup build artifacts")
    .Does(() => {
        CleanDirectory("build");
        CleanDirectories("**/obj");
    });

Task("DocFX-Build")
    .Description("Generate and the website")
    .Does(() => {
        DocFxBuild("./doc/docfx.json");
    });

Task("DocFX-Serve")
    .Description("Generate and serve the website at http://localhost:8080")
    .Does(() => {
        DocFxBuild("./doc/docfx.json", new DocFxBuildSettings {
            Serve=true
        });
    });

RunTarget(target);