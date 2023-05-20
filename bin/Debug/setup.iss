[Setup]
AppName=AplikasiBengkelKu
AppVerName=SI AplikasiBengkelKu Univ AMIKOM Yogyakarta Versi 1.0.0
AppPublisher=4EverGroups
AllowCancelDuringInstall = yes
DefaultDirName={pf}\AplikasiBengkelKu
DefaultGroupName=AplikasiBengkelKu
Compression = lzma
SolidCompression = yes
OutputBaseFilename=SetupAplikasiBengkelKu
AllowNoIcons = yes
AlwaysRestart = no
AlwaysShowComponentsList = no
DisableProgramGroupPage = yes
AppendDefaultDirName = yes
CreateUninstallRegKey = yes
DisableStartupPrompt = yes
LanguageDetectionMethod=none
ShowLanguageDialog=no
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\AplikasiBengkelKu.exe,0
UninstallDisplayName=AplikasiBengkelKu
WindowVisible = no
AppCopyright=Copyright © 2021. 4EverGroups
FlatComponentsList = yes
PrivilegesRequired = admin
VersionInfoVersion=1.0.0.0
SetupIconFile=Setup.ico
;WizardImageFile=SetupModern21.bmp
;WizardSmallImageFile=SetupModernSmall21.bmp

[Languages]
Name: ina; MessagesFile: compiler:Indonesian.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Files]
Source: AplikasiBengkelKu.exe; DestDir: {app}; Flags: ignoreversion
Source: AplikasiBengkelKu.exe.config; DestDir: {app}; Flags: ignoreversion

;Source: bin\Database\DbPerpustakaan.mdb; DestDir: {app}\Database; Flags: ignoreversion
Source: DatabaseBengkel.mdf; DestDir: {app}\Database; Flags: ignoreversion

Source: Apk.ico; DestDir: {app}; Flags: ignoreversion

[Dirs]

Name:{app}”;Permissions:users-full

[Icons]
Name: {group}\AplikasiBengkelKu; Filename: {app}\AplikasiBengkelKu.exe; WorkingDir: {app}; IconFilename: {app}\Apk.ico
Name: {userdesktop}\AplikasiBengkelKu; Filename: {app}\AplikasiBengkelKu.exe; WorkingDir: {app}; IconFilename: {app}\Apk.ico; Tasks: desktopicon

[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\AplikasiBengkelKu"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue