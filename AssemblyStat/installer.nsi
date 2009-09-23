; example1.nsi
;
; This script is perhaps one of the simplest NSIs you can make. All of the
; optional settings are left to their default settings. The installer simply 
; prompts the user asking them where to install, and drops a copy of example1.nsi
; there. 

;--------------------------------

; The name of the installer
Name "QuickAssemblyInfo"

; The file to write
OutFile "QuickAssemblyInfo.exe"

; The default installation directory
InstallDir $PROGRAMFILES\QuickAssemblyInfo

;--------------------------------

; Pages

Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------

; The stuff to install
Section "Quick Assembly Info" ;No components page, name is not important

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File "bin\Release\AssemblyStat.exe"
  
  WriteRegStr HKCR "dllfile\Shell\Assembly Info\Command\" "" "$INSTDIR\AssemblyStat.exe $\"%1$\""

  WriteUninstaller "uninstall.exe"

SectionEnd ; end the section

Section "Uninstall"
  
  ; Remove registry keys
  DeleteRegKey HKCR "dllfile\Shell\Assembly Info"

  ; Remove files and uninstaller
  Delete $INSTDIR\AssemblyStat.exe
  Delete $INSTDIR\uninstall.exe

  ; Remove directories used
  RMDir "$INSTDIR"

SectionEnd
