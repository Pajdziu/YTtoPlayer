﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YTtoPlayer.Core.Resources.Localization {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Localization {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Localization() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("YTtoPlayer.Core.Resources.Localization.Localization", typeof(Localization).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to YouTube to MP3 Player.
        /// </summary>
        public static string AppTitle {
            get {
                return ResourceManager.GetString("AppTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose location.
        /// </summary>
        public static string ChooseLocation {
            get {
                return ResourceManager.GetString("ChooseLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download.
        /// </summary>
        public static string Download {
            get {
                return ResourceManager.GetString("Download", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Info.
        /// </summary>
        public static string Info {
            get {
                return ResourceManager.GetString("Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load info.
        /// </summary>
        public static string LoadInfo {
            get {
                return ResourceManager.GetString("LoadInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location.
        /// </summary>
        public static string Location {
            get {
                return ResourceManager.GetString("Location", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Paste YouTube video&apos;s URL here.
        /// </summary>
        public static string PasteYouTubeUrl {
            get {
                return ResourceManager.GetString("PasteYouTubeUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Url.
        /// </summary>
        public static string Url {
            get {
                return ResourceManager.GetString("Url", resourceCulture);
            }
        }
    }
}
