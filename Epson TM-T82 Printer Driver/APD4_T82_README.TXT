EPSON Advanced Printer Driver for TM-T82 Ver.4

                                     Copyright (c) 2014 SEIKO EPSON CORPORATION


1. About this software
This package includes the following two software programs to use with an EPSON 
TM-T82 printer.

1) Windows Printer Driver
This driver is a Windows Printer Driver for the TM-T82 printer. This driver makes 
it possible to print from a Windows application.

2) StatusAPI
StatusAPI is a program that works in conjunction with the TM-T82 printer driver.  
It offers an Application Program Interface for obtaining the printer status 
whether or not the printer is printing.  This API makes integrating printer
status handling functions with applications more simple.

For detailed information, please see each reference manual.

The driver operation has been verified with the following operating systems. 

    Windows 8.1 Pro 32/64bit
    Windows 8 Pro 32/64bit
    Windows 7 Ultimate 32/64bit
    Windows Vista Ultimate SP2 Simplified Chinese 32/64bit
    Windows XP Professional SP3 Simplified Chinese 32bit
    Windows Server 2012 R2 64bit
    Windows Server 2012 64bit
    Windows Server 2008 R2 Enterprise 64bit
    Windows Server 2008 Standard/DataCenter SP2 Simplified Chinese 32bit
    Windows Server 2008 Standard SP2 Simplified Chinese 64bit
    Windows Server 2003 R2 Enterprise SP2 Simplified Chinese 32bit
    Windows Server 2003 R2 Standard SP2 Simplified Chinese 64bit
    Windows XP Embedded 32bit SP2
    Windows Embedded Standerd 2009 32bit
    Windows Embedded POSReady 2009 32bit
    Windows Embedded POSReady 7

This driver is not supported by Windows 95/98/NT/2000 and Windows XP 64bit.

EPSON IM series PC or IBM compatible PC
 
Supported Printers
  EPSON TM-T82

The printer driver operates regardless of the pritner firmware version.

2. Supplied Files
   APD_456WM_T82.zip  : Printer Driver,StatusAPI installer with manuals

Refer to the installation manual APD4_T82_Install_SC_RevD.pdf, APD4_T82_Install_SA_RevD.pdf.

3. Remarks
- For detailed information, please read each manual that is created by the 
  installation.

-When an error message is displayed during installation, the following procedure may enable to recover from the error.
  1) Specify the uninstall option, and execute the installer "APD_456_T82.exe /uninstall".
  2) Remove the error factor.
  3) Execute the installer "APD_456_T82.exe".

-Characters may not be printed correctly when using Easy Print of Windows Server 2008.
 For detailed information of this problem arising from the operating system,
 see the following web page provided by Microsoft Corporation.
  http://support.microsoft.com/kb/946411/

-In the Easy Print environment of Windows Server 2008, you cannot print the printer device font directly.
 However, you can print the device font converted from the True Type font by using "Font Substitution" of APD.
 For more information, see "Character Printing (Device Font)" in Printer Manual.

-To set properties of the printer driver redirected on the server using Terminal Service or Remote Desktop
 on the printer driver on a client, go to [Advanced] Tab, and press the [Printing Defaults] button.

-HELP is unavailable when using a printer driver redirected through the server using Terminal Service or Remote Desktop.

-When using Terminal Service and Remote Desktop, interactive communication becomes unavailable between the PC and the printer,
 prohibiting displaying the printer status and obtaining printer information using the Status API.

-The port redirection function is unavailable for a client when using Terminal Service or Remote Desktop.

-At times, the status of the shared printer may not be displayed correctly or the Status API may not be opened.
 These problems arise from the security policy settings of the operating system.
 Although changing the settings of the operating system is possible by the following steps, it lowers the security policy.
 (1) Go to [Start] - [Administrative tool] - [Local Security Policy].
 (2) [Security Option] - [Network Access (Set "Limit anonymous sccesses to the named pipe and shared printer" to "Invalid".)]
 However, you do not have to change the settings when a client PC is connected to the domain environment and
 when the same user name as a user name that is logged on a client is existing."

-Please use the same version of EPSON Advanced Printer Driver for each host when a network printer is shared among two or more hosts.

-About how to use .Net module on Windows7/8.
  In case of Visual Basic .NET (Windows7/8).
    Example of Visual Basic .NET environment.
    1 Execute Microsoft Visual Basic and and run project window.
    2 Right click for [Reference settings] on Solution explorer and select [add reference].
    3 "Add reference" window is shown and click [Reference] tab.
    4 Select "C:\Programfiles\Epson\Advanced Printer Tool\StatusAPI" in  [File location] and open.
      -In case of 64bitOS, specify "C:\Program Files(x86)\Epson\Advanced Printer Tool\StatusAPI".
    5 Input "EpsonStatusAPI.dll" in [file] menu and click [OK] to select.
    6 Select [ Reference setting ] - [EpsonStatusAPI] in solution explorer.
      And set "False" on [specific version] property.
    7 Add following description in the source code using Imports statement.
      Imports com.epson.pos.driver
    8 Visual Basic .NET is now ready. You can develop application development using Status API.
  In case of Visual C# (Windows7/8).
    Following is example of Visual C# development.
    1 Execute Microsoft Visual C# and run project window.
    2 Right click for [Reference settings] on Solution explorer and select [add reference].
    3 "Add reference" window is shown and click [Reference] tab.
    4 Select "C:\Programfiles\Epson\Advanced Printer Tool\StatusAPI" in [File location] and open.
      -In case of 64bitOS, specify "C:\Program Files(x86)\Epson\Advanced Printer Tool\StatusAPI".
    5 Input "EpsonStatusAPI.dll" in [file] menu and click [OK] to select.
    6 Select [ Reference setting ] - [EpsonStatusAPI] in solution explorer.
      And set "False" on [specific version] property.
    7 Add following description in the source code using "using" keyward.
      using com.epson.pos.driver
    8 Visual Basic .NET is now ready. You can develop application development using Status API.

4.Modification from the old version
  Ver4.56
     -The following problem has been solved:
         -By ethernet, there is a possibility of no print
         -By ethernet, there is a possibility of stopping the print when used with  Status API
         -There is a possibility of stopping the print after BiCloseMonPrinter
         -If BiOpenMonPrinter is faster than spooler open port, then does not print
         -The speed of the BiOpenMonPrinter function of StatusAPI is slow.
         -Printer status may come to remain "initializing".

  Ver4.55c
     -Support the parallel interface model.

  Ver4.55b
     -The following problem has been solved:
         -The data are resent to a printer again in BiDirectIO/BiDirectIOEx of StatusAPI.

  Ver4.55
     -Fix the problem of dividing the barcode when included the specific code(e.g."-") in input data.
     -Change the initial values of printer monitoring time and timeout at using Ethernet I/F.
         Status Polling Interval           3000(ms)
         Status Polling Timeout            2000(ms)
         Power Status Polling Interval     1000(ms)
         Power Status Polling Timeout      1000(ms)
         Power Status Polling Retry Count     3(times)
         Wireless Offline Count               1(time)
         Wireless Power Off Count             3(times)
         Wired Offline Count                  1(time)
         Wired Power Off Count                1(time)
     -The following problem has been solved:
         -There is a possibility of stopping the print by sending job to the printer from multiple PCs at the same time via Ethernet I/F.
         -There is a possiblity of to occur the garbage print by occurring lucking data in printing.
         -There is a possibility of to occur the while-loop(no end process) from BiCloseMonPrinter().
         -No print if contained "%" on document name.
         -There is a possibility of No print by image mode on 64bit OS.

  Ver4.54
     -Supports the following OS
          Microsoft Windows 8 32/64bit
          Microsoft Windows Server 2012 64bit
     -Revised the contents of EpsStmApi.h for StatusAPI.
     -Added support for .NET Framework 4.0.
     -The following problem has been solved:
         -During continued printing, the following kinds of prints are delayed.
         -Error recovery is not performed properly even when BiResetPrinter（）/BiForceResetPrinter（）is executed.

  Ver4.53
     -Silent install package is possible to install to any Windows OS version.
     -Can specify install folder for .Net module.
     -Add TMUSB Ver6.10a in the same package.

  Ver4.52
     -The following problem has been solved:
        -When the barcode of Code39 or Code93 print using DrawText function, the barcode is divided into two.

  Ver4.50
     -Support Traditional Chainese.
     -Changed port setting window.
     -Newly added printer IP address setting to the port setting window.
     -Changed log setting window.
     -Supports the following OS
          Microsoft Windows Embedded POSReady 7

  Ver4.15b
      -The following problem has been solved:
         -The temporary files generated at the time of printing are left.

  Ver4.15a
      -Support Ether port.

  Ver4.13a
      -New release. 
