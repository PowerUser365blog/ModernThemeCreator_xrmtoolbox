using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace ModernThemeCreator
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Modern Theme Creator"),
        ExportMetadata("Description", "Create or update your Theme Setting"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "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"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "#FAF8EC"),
        ExportMetadata("PrimaryFontColor", "#042246"),
        ExportMetadata("SecondaryFontColor", "#1987FA")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new ModernThemeCreatorControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}