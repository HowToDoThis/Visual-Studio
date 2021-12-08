namespace DiscordRPforVS
{
    using Properties;
    using System;
    using System.Collections.Generic;

    public static class Constants
    {
        public static readonly Dictionary<String[], String[]> Languages = new Dictionary<String[], String[]>
        {
            // VS Default Supported
            { new String[] { ".CS" }, new String[] { "csharp", "C#" } },
            { new String[] { ".BAS", ".CLS", ".FRM", ".VBP", ".VBG" }, new String[] { "visualbasic", "VB" } },
            { new String[] { ".FS", ".FSI", ".FSX", ".FSSCRIPT" }, new String[] { "fsharp", "F#" } },
            { new String[] { ".H", ".C", ".CC", ".HH", ".CPP", ".IPP", ".INL", ".C++", ".H++", ".HPP" }, new String[] { "c/cpp", "C/C++" } },
            { new String[] { ".VSCT" }, new String[] { "vscmdtable", Translates.VSCTDocument(Settings.Default.translates) } },
            { new String[] { "DOCKERFILE" }, new String[] { "docker", "Docker" } },
            { new String[] { ".MDF", ".NDF", ".LDF" }, new String[] { "sql-server-tools", "SQL Server Tools" } },
            { new String[] { ".SQL" }, new String[] { "sql", "SQL" } },
            { new String[] { ".XAML" }, new String[] { "xaml", "XAML" } },
            { new String[] { ".YAML" }, new String[] { "yaml", "YAML" } },
            // ASP.NET
            { new String[] { ".ASAX", ".ASCX", ".ASHX", ".ASMX", ".ASPX", ".AXD", ".SITEMAP" }, new String[] { "asp.net", "ASP.NET" } },
            { new String[] { ".CSHTML", ".RAZOR", ".VBHTML" }, new String[] { "razor", "Razor" } },
            // Web
            { new String[] { ".HTML" }, new String[] { "html", "Html" } },
            { new String[] { ".CSS" }, new String[] { "css", "CSS" } },
            { new String[] { ".SCSS", ".SASS" }, new String[] { "sass", "SASS" } },
            { new String[] { ".LESS" }, new String[] { "less", "LESS" } },
            // JS/TS
            { new String[] { ".JS" }, new String[] { "javascript", "JavaScript" } },
            { new String[] { ".TS" }, new String[] { "typescript", "TypeScript" } },

            { new String[] { ".GO" }, new String[] { "go", "GO" } },
            { new String[] { ".PHP" }, new String[] { "php", "PHP" } },
            { new String[] { ".RB", ".RBW" }, new String[] { "ruby", "Ruby" } },
            { new String[] { ".CLASS", ".JAVA" }, new String[] { "java", "Java" } },
            { new String[] { ".PY", ".PYW", ".PYI", ".PYX" }, new String[] { "python", "Python" } },
            { new String[] { ".LUA" }, new String[] { "lua", "Lua" } },
            { new String[] { ".RS" }, new String[] { "rust", "Rust" } },

            { new String[] { ".TOML" }, new String[] { "toml", "TOML" } },

            // System or common file types
            { new String[] { ".JSON" }, new String[] { "json", "JSON" } },
            { new String[] { ".XML" }, new String[] { "xml", "XML" } },
            { new String[] { ".MD", ".MARKDOWN" }, new String[] { "markdown", "Markdown" } },
            { new String[] { "CMAKELISTS.TXT", "CMAKECACHE.TXT" }, new String[] { "cmake", "CMake" } },
            { new String[] { ".TXT" }, new String[] { "text", Translates.TextDocument(Settings.Default.translates) } },
            { new String[] { ".LOG" }, new String[] { "log", Translates.LogDocument(Settings.Default.translates) } },
        };

        public static readonly Dictionary<Int32, String> IdeVersions = new Dictionary<Int32, String>
        {
            { 15, "2017" },
            { 16, "2019" }
        };
    }
}
