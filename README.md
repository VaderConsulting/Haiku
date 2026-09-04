# Haiku

VB.NET VS 2010 working copy of Stratatel Haiku Candy: VSTO Outlook 2007/2010 add-ins (assemblies Stratatel.HaikuCandy2007 / Stratatel.HaikuCandy2010) that set a new MailItem to HTML and inject the HaikuCandy.com signature images. WinForms Setup2 / Setup3.5 / Setup4 detect Windows and Outlook versions and map the Microsoft Signatures folder (Configure is mostly comments); SetupWPF3.5 and SetupWPF4 are empty MainWindow shells, with Visual Studio installer projects SetupOutlook2007Addin / SetupOutlook2010Addin and a Backup 2007 add-in. Open `Haiku.sln`. This is a historical working copy from Dave Robinson / VaderConsulting (Stratatel-era Haiku Candy).

**Source last updated:** 2011-07-05  
**Language:** VB.NET  
**Target:** v2.0, v3.5, v4.0  
**Output:** Library, WinExe

## What it is

VB.NET VS 2010 working copy of Stratatel Haiku Candy: VSTO Outlook 2007/2010 add-ins (assemblies Stratatel.HaikuCandy2007 / Stratatel.HaikuCandy2010) that set a new MailItem to HTML and inject the HaikuCandy.com signature images. WinForms Setup2 / Setup3.5 / Setup4 detect Windows and Outlook versions and map the Microsoft Signatures folder (Configure is mostly comments); SetupWPF3.5 and SetupWPF4 are empty MainWindow shells, with Visual Studio installer projects SetupOutlook2007Addin / SetupOutlook2010Addin and a Backup 2007 add-in. Open `Haiku.sln`. This is a historical working copy from Dave Robinson / VaderConsulting (Stratatel-era Haiku Candy).

## Solution structure

| Project | Language | Path |
|---------|----------|------|
| `Outlook2007Addin` | VB.NET | `Outlook2007Addin/Outlook2007Addin.vbproj` |
| `Setup3.5` | VB.NET | `Setup3.5/Setup3.5.vbproj` |
| `Setup2` | VB.NET | `Setup2/Setup2.vbproj` |
| `Outlook2010AddIn` | VB.NET | `Outlook2010AddIn/Outlook2010AddIn.vbproj` |
| `SetupWPF3.5` | VB.NET | `SetupWPF3.5/SetupWPF3.5.vbproj` |
| `SetupWPF4` | VB.NET | `SetupWPF4/SetupWPF4.vbproj` |
| `Outlook2007Addin` | VB.NET | `Backup/Outlook2007Addin.vbproj` |
| `Setup4` | VB.NET | `Setup4/Setup4.vbproj` |

## How to open

Open `Haiku.sln` in Visual Studio.

## Requirements

- Visual Studio 2010, .NET Framework 2.0, .NET Framework 3.5, .NET Framework 4.0

## Attribution and provenance

- **Assembly company:** Microsoft, Stratatel Ltd
- **Assembly copyright:** Copyright @ Microsoft 2011, Copyright © Microsoft 2011, Copyright © Stratatel Ltd 2011

## License

MIT. See `LICENSE`.
