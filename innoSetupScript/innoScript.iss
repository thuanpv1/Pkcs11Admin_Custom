; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
SignTool=MsSign $f
AppId={{1867383A-0FEC-4276-A274-13B88DEBF48D}
AppName=Token Manager
AppVersion=1.0
;AppVerName=Token Manager 1.0
AppPublisher=Evergreen Technology
AppPublisherURL=https://egt.vn
AppSupportURL=https://egt.vn
AppUpdatesURL=https://egt.vn
DefaultDirName={pf}\Token Manager
DefaultGroupName=Token Manager
OutputDir=D:\TokenManagerTemp\publish
OutputBaseFilename=TokenManager1.0
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Registry]
Root: HKLM; Subkey: "Software\TokenManager\listCardToUnlock"; Flags: createvalueifdoesntexist
Root: HKLM; Subkey: "Software\TokenManager\listCardToUnlock"; ValueType: string; ValueName: "listOfCardToUnlock"; ValueData: "{olddata}"; Permissions: users-modify;

[Files]
Source: "D:\TokenManagerTemp\Quynh_Pkcs11Admin-0.5.0\Pkcs11Admin-0.5.0\src\Pkcs11Admin.WinForms\bin\x86\Release\TokenManager.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\TokenManagerTemp\Quynh_Pkcs11Admin-0.5.0\Pkcs11Admin-0.5.0\src\Pkcs11Admin.WinForms\bin\x86\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\TokenManagerTemp\Quynh_Pkcs11Admin-0.5.0\Pkcs11Admin-0.5.0\src\Pkcs11Admin.WinForms\bin\x86\Release\driver\ChipDocLiteToken.dll"; DestDir: "{sys}"; Flags: ignoreversion
Source: "D:\TokenManagerTemp\Quynh_Pkcs11Admin-0.5.0\Pkcs11Admin-0.5.0\src\Pkcs11Admin.WinForms\bin\x86\Release\driver\ciamd\ciamd.dll"; DestDir: "{sys}"; Flags: onlyifdoesntexist
Source: "D:\TokenManagerTemp\Quynh_Pkcs11Admin-0.5.0\Pkcs11Admin-0.5.0\src\Pkcs11Admin.WinForms\bin\x86\Release\driver\ciamd\ciamd64.dll"; DestDir: "{sys}"; Flags: onlyifdoesntexist
Source: "D:\TokenManagerTemp\Quynh_Pkcs11Admin-0.5.0\Pkcs11Admin-0.5.0\src\Pkcs11Admin.WinForms\bin\x86\Release\driver\lasermd\lasermd.dll"; DestDir: "{sys}"; Flags: onlyifdoesntexist
Source: "D:\TokenManagerTemp\Quynh_Pkcs11Admin-0.5.0\Pkcs11Admin-0.5.0\src\Pkcs11Admin.WinForms\bin\x86\Release\driver\lasermd\lasermd64.dll"; DestDir: "{sys}"; Flags: onlyifdoesntexist

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Token Manager"; Filename: "{app}\TokenManager.exe"
Name: "{commondesktop}\Token Manager"; Filename: "{app}\TokenManager.exe"; Tasks: desktopicon
[Run]
Filename: "{sys}\rundll32.exe"; Parameters: "setupapi,InstallHinfSection DefaultInstall 128 {app}\driver\athenaSmartCardDriver_ciamd\ciamd.inf"; WorkingDir: {app}\driver; Description: "Install driver"; Flags: 32bit;
Filename: "{app}\certmgr.exe"; Parameters: "-add -all -c evergreenca.cer -s -r localmachine trustedpublisher"; Flags: waituntilterminated runhidden;
