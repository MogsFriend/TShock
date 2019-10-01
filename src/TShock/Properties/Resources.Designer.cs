﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TShock.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TShock.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to By-reference argument &quot;{0}&quot; is not supported..
        /// </summary>
        internal static string CommandCtor_ArgIsByReference {
            get {
                return ResourceManager.GetString("CommandCtor_ArgIsByReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pointer argument &quot;{0}&quot; is not supported..
        /// </summary>
        internal static string CommandCtor_ArgIsPointer {
            get {
                return ResourceManager.GetString("CommandCtor_ArgIsPointer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception occurred while executing command..
        /// </summary>
        internal static string CommandInvoke_Exception {
            get {
                return ResourceManager.GetString("CommandInvoke_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Long flag &quot;--{0}&quot; was unexpected..
        /// </summary>
        internal static string CommandParse_BadLongFlag {
            get {
                return ResourceManager.GetString("CommandParse_BadLongFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional argument &quot;{0}&quot; was unexpected..
        /// </summary>
        internal static string CommandParse_BadOptional {
            get {
                return ResourceManager.GetString("CommandParse_BadOptional", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Short flag &quot;-{0}&quot; was unexpected..
        /// </summary>
        internal static string CommandParse_BadShortFlag {
            get {
                return ResourceManager.GetString("CommandParse_BadShortFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No parser found for argument type &quot;{0}&quot;..
        /// </summary>
        internal static string CommandParse_NoParserFound {
            get {
                return ResourceManager.GetString("CommandParse_NoParserFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many arguments were provided..
        /// </summary>
        internal static string CommandParse_TooManyArgs {
            get {
                return ResourceManager.GetString("CommandParse_TooManyArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is a number that is out of range of an integer..
        /// </summary>
        internal static string Int32Parser_IntegerOutOfRange {
            get {
                return ResourceManager.GetString("Int32Parser_IntegerOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is not a valid integer..
        /// </summary>
        internal static string Int32Parser_InvalidInteger {
            get {
                return ResourceManager.GetString("Int32Parser_InvalidInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No integer was provided..
        /// </summary>
        internal static string Int32Parser_MissingInteger {
            get {
                return ResourceManager.GetString("Int32Parser_MissingInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected end of input..
        /// </summary>
        internal static string StringParser_EndOfInput {
            get {
                return ResourceManager.GetString("StringParser_EndOfInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Escape character &quot;\{0}&quot; was unexpected..
        /// </summary>
        internal static string StringParser_UnexpectedEscape {
            get {
                return ResourceManager.GetString("StringParser_UnexpectedEscape", resourceCulture);
            }
        }
    }
}
