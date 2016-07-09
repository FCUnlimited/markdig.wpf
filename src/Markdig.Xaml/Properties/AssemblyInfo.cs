﻿using System.Reflection;
using System.Resources;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Markdig.Xaml")]
[assembly: AssemblyDescription("a XAML port to CommonMark compliant Markdig.")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Markdig.Xaml")]
[assembly: AssemblyCopyright("Copyright © Nicolas Musset 2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en")]

[assembly: AssemblyVersion(Markdig.Xaml.Version)]
[assembly: AssemblyFileVersion(Markdig.Xaml.Version)]

namespace Markdig
{
    public static class Xaml
    {
        public const string Version = "0.0.1";
    }
}
