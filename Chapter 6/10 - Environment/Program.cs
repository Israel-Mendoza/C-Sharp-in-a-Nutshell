using static System.Environment;
using static System.Console;
using System.Diagnostics;

// Files and folders
var pwd = CurrentDirectory;
var sd = SystemDirectory;
var cl = CommandLine;

WriteLine(pwd);
WriteLine(sd);
WriteLine(cl);

// Computer and OS
var c = MachineName;
var pc = ProcessorCount;
var osv = OSVersion;
var nl = NewLine;

WriteLine(c);
WriteLine(pc);
WriteLine(osv);
WriteLine(nl);

// User logon
var un = UserName;
var ui = UserInteractive;
var udn = UserDomainName;

WriteLine(un);
WriteLine(ui);
WriteLine(udn);

// Diagnostics
var tc = TickCount;
var st = Environment.StackTrace;
var ws = WorkingSet;

WriteLine(tc);
WriteLine(st);
WriteLine(ws);

Process.Start("code", ".");
