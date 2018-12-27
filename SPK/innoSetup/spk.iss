; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "SPK"
#define MyAppVersion "1.5"
#define MyAppPublisher "JENO INNOVATIONS"
#define MyAppURL "http://spk.toxaswift.com"
#define MyAppExeName "SPK.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{D2B5564F-44A4-4A7E-80D9-DAFF1AF18F4E}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\license.txt
OutputDir=C:\Users\User\Desktop\spk
OutputBaseFilename=setup
SetupIconFile=C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\jeno.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\SPK.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\DB.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\DB.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\DB.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\EntityFramework.SqlServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\EnvDTE.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\EnvDTE80.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\EPPlus.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\EPPlus.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Google.Protobuf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Google.Protobuf.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.Build.Framework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.Build.Tasks.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.Build.Utilities.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.MSXML.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.ReportViewer.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.ReportViewer.DataVisualization.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.ReportViewer.Design.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.ReportViewer.ProcessingObjectModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.ReportViewer.WinForms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.SqlServer.Types.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.ComponentModelHost.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.Data.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.Data.Services.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.Debugger.Interop.11.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.Debugger.InteropA.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.GraphModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.ManagedInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.OLE.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.ProjectAggregator.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.Shell.Interop.10.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.Shell.Interop.11.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.Shell.Interop.8.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.Shell.Interop.9.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.Shell.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.TemplateWizardInterface.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.TemplateWizardInterface.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.TextManager.Interop.10.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.TextManager.Interop.8.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.TextManager.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Microsoft.VisualStudio.VSHelp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\MySql.Data.Entity.EF6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\MySql.Data.Entity.EF6.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\MySqlBackup.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\noImageFound.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\small.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\SPK.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\SPK.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\SPK.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\SPK.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\stdole.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\System.Threading.Tasks.Dataflow.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\VSLangProj.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\VSLangProj2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\VSLangProj80.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\app.publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\de\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\es\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\fr\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\it\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\publish\Application Files\SPK_1_0_0_1\ja\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\ko\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\ko\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\pt\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\ru\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\SqlServerTypes\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\zh-CHS\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\OneDrive\Visual Studio 2017\Projects\SPK\SPK\bin\Release\zh-CHT\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
