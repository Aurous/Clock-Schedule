// Decompiled with JetBrains decompiler
// Type: Clock4School.Properties.Settings
// Assembly: Clock4School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 09B1CF10-0326-43F8-B308-8A802A05E20C
// Assembly location: C:\Users\ltrya\Desktop\Clock4School.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Clock4School.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings settings = Settings.defaultInstance;
        return settings;
      }
    }
  }
}
