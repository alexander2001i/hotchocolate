﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Execution.Properties {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("HotChocolate.Execution.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string ThrowHelper_MissingDirectiveIfArgument {
            get {
                return ResourceManager.GetString("ThrowHelper_MissingDirectiveIfArgument", resourceCulture);
            }
        }
        
        internal static string ThrowHelper_FieldDoesNotExistOnType {
            get {
                return ResourceManager.GetString("ThrowHelper_FieldDoesNotExistOnType", resourceCulture);
            }
        }
        
        internal static string ObjectBuffer_IsEmpty {
            get {
                return ResourceManager.GetString("ObjectBuffer_IsEmpty", resourceCulture);
            }
        }
        
        internal static string ObjectBuffer_IsUsedUp {
            get {
                return ResourceManager.GetString("ObjectBuffer_IsUsedUp", resourceCulture);
            }
        }
        
        internal static string PreparedSelection_ReadOnly {
            get {
                return ResourceManager.GetString("PreparedSelection_ReadOnly", resourceCulture);
            }
        }
        
        internal static string MiddlewareContext_ReportErrorCannotBeNull {
            get {
                return ResourceManager.GetString("MiddlewareContext_ReportErrorCannotBeNull", resourceCulture);
            }
        }
    }
}
