// Decompiled with JetBrains decompiler
// Type: Clock4School.Properties.Resources
// Assembly: Clock4School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 09B1CF10-0326-43F8-B308-8A802A05E20C
// Assembly location: C:\Users\ltrya\Desktop\Clock4School.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Clock4School.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Clock4School.Properties.Resources.resourceMan == null)
          Clock4School.Properties.Resources.resourceMan = new ResourceManager("Clock4School.Properties.Resources", typeof (Clock4School.Properties.Resources).Assembly);
        return Clock4School.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Clock4School.Properties.Resources.resourceCulture;
      }
      set
      {
        Clock4School.Properties.Resources.resourceCulture = value;
      }
    }

    internal Resources()
    {
    }
  }
}
