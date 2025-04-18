; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "vTimer"
#define MyAppVersion "25.3"
#define MyAppPublisher "VVV"
#define MyAppURL "www.adonis-soft.ru"
#define MyAppExeName "VTimer.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{00A4FEC9-73E4-40B1-A666-FB62D766E649}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
; "ArchitecturesAllowed=x64compatible" specifies that Setup cannot run
; on anything but x64 and Windows 11 on Arm.
ArchitecturesAllowed=x64compatible
; "ArchitecturesInstallIn64BitMode=x64compatible" requests that the
; install be done in "64-bit mode" on x64 or Windows 11 on Arm,
; meaning it should use the native 64-bit Program Files directory and
; the 64-bit view of the registry.
ArchitecturesInstallIn64BitMode=x64compatible
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only).
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=D:\LAB\VS\VTimer\VTimerSetup\ 
OutputBaseFilename=VTimerSetup
SetupIconFile=D:\LAB\VS\VTimer\VTimer\Resources\alarm.ico
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "norwegian"; MessagesFile: "compiler:Languages\Norwegian.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\LAB\VS\VTimer\VTimer\bin\Release\net9.0-windows7.0\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\LAB\VS\VTimer\VTimer\bin\Release\net9.0-windows7.0\VTimer.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\LAB\VS\VTimer\VTimer\bin\Release\net9.0-windows7.0\VTimer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\LAB\VS\VTimer\VTimer\bin\Release\net9.0-windows7.0\VTimer.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\LAB\VS\VTimer\VTimer\bin\Release\net9.0-windows7.0\VTimer.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\LAB\VS\VTimer\VTimer\bin\Release\net9.0-windows7.0\VTimer.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\LAB\VS\VTimer\VTimer\bin\Release\net9.0-windows7.0\VTimer.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\LAB\VS\VTimer\VTimer\bin\Release\net9.0-windows7.0\sound\*"; DestDir: "{app}\sound"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

