; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define Name "List Of Student"

#define Version "1.0"

#define Publisher "Isaichenko Nikita"

#define ExeName "ListOfStudents.exe"

#define IconName "AppIcon.ico"

[Setup]

AppId={{1F39445B-9523-4BD4-9C04-74B0B9793AB9}

AppName={#Name}
AppVersion={#Version}
AppVerName = {#Name}
AppPublisher={#Publisher}

DefaultDirName={commonpf}\{#name}

DefaultGroupName={#Name}

OutputDir=/Setup
OutputBaseFilename=setup

SetupIconFile={#IconName}
UninstallDisplayIcon = {app}\Resources\{#IconName}

Compression=lzma
SolidCompression=yes


[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "groupfolder"; Description: "������� ����� � ���� ����";  GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked


[Files]
Source: "..\ListOfStudents\ListOfStudents\bin\Release\{#ExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\ListOfStudents\ListOfStudents\bin\Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "..\ListOfStudents\ListOfStudents\Resources\*"; DestDir: "{app}\Resources"; Flags: ignoreversion recursesubdirs createallsubdirs
[Icons]
Name: "{group}\Uninstall.exe"; Filename: "Uninstallexe"; IconFilename: "{app}\Resources\{#IconName}";
Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"; Tasks: groupfolder; WorkingDir: "{app}"; IconFilename: "{app}\Resources\{#IconName}"
Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; Tasks: desktopicon; IconFilename: "{app}\Resources\{#IconName}"

[Run]
Filename: "{app}\{#ExeName}"; Description: "{cm:LaunchProgram,{#StringChange(Name, '&', '&&')}}"; Flags: nowait postinstall skipifsilent