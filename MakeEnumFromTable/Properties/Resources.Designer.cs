﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MakeEnumFromTable.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MakeEnumFromTable.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to 0	Jump State
        ///1	Play PAX effect from a.fm
        ///2	Play footstep sound
        ///3	Dusk Jump State (animation in slot 628)
        ///4	Texture animation start
        ///5	Texture animation stop (UNUSED?)
        ///6	Use Item effect
        ///7	&lt;unknown&gt; (LIMIT: AnmatrCallback; Limit RC?)
        ///8	Play SE sound from a.fm
        ///9	&lt;unknown&gt; (VariousTrigger 1)
        ///10	&lt;unknown&gt; (VariousTrigger 2)
        ///11	&lt;unknown&gt; (VariousTrigger 4)
        ///12	&lt;unknown&gt; (VariousTrigger 8)
        ///13	Plays an enemy vsb voice
        ///14	Plays an ally vsb voice
        ///15	Turn to Target
        ///16	&lt;unknown&gt; (DisableCommandTime; Eg: W [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Frame {
            get {
                return ResourceManager.GetString("Frame", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0	STATE: Grounded
        ///1	STATE: Falling
        ///2	STATE: Grounded 2
        ///3	STATE: No gravity
        ///4	Enable collision flag
        ///5	Disable collision flag
        ///6	Enable RECOM flag
        ///7	Disable RECOM flag (UNUSED?)
        ///8	&lt;unknown&gt; (Prints “using NO_DAMAGE_REACTION attribute”?) (UNUSED?)
        ///9	STATE: &lt;unknown&gt;
        ///10	Motion attack on
        ///11	STATE: Allows combo attack
        ///12	STATE: &lt;unknown&gt;
        ///13	STATE: &lt;unknown&gt;
        ///14	STATE: Allows Battle RCs
        ///15	STATE: &lt;unknown&gt; (UNUSED?)
        ///16	&lt;unknown&gt; (“Mobility enhancement”, eg: LW’s dash)
        ///17	&lt;unknown&gt; (AI combo 1)
        ///18	&lt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Range {
            get {
                return ResourceManager.GetString("Range", resourceCulture);
            }
        }
    }
}
