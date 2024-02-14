﻿using Cosmos.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;
using ConsoleX = ADOS.Tools.ConsoleX;

namespace ADOS.Tools
{
    public static class Tools
    {
        public static readonly string version = "debug 2023.11.07.0";

        public static void About()
        {
            Console.Clear();
            Asci_Art.Print("PIATOS");
            ConsoleX.Print("an Operating System ");
            ConsoleX.Print("made by GEM (Gerald, Eubert, eMjay");
          
        }

        public static void Help()
        {
            ConsoleX.Set_color(ConsoleX.red);
            Asci_Art.Print("HELP");
            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("Power:");
            Console.ResetColor();

            ConsoleX.Print("shutdown - shutdown");
            ConsoleX.Print("reboot - restart\n");

            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("File System controll:");
            Console.ResetColor();

            ConsoleX.Print("mkfile - makes a file");
            ConsoleX.Print("readfile - read the file");
            ConsoleX.Print("editfile - edit file");
            ConsoleX.Print("rewritefile - rewriting the file");
            ConsoleX.Print("runfile - runs a file");
            ConsoleX.Print("mkdir - makes dir");
            ConsoleX.Print("delfile - delets file");
            ConsoleX.Print("deldir - delets directory");

            ConsoleX.Print("cd - changes local path");
            ConsoleX.Print("cdf - changes global path");

            Console.WriteLine("movfile - moves file");

            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("\nInternet:");
            Console.ResetColor();
            ConsoleX.Print("ip - gets current ip adress");

            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("Test Functions:");
            Console.ResetColor();
            ConsoleX.Print("bsod - call Blacl Screen Of Death");
            ConsoleX.Print("asci - write big letters that made from asci symbols");

            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("System Functions:");
            Console.ResetColor();
            ConsoleX.Print("about - gets the version and info about OS");
            ConsoleX.Print("time - gets time and date");
            ConsoleX.Print("gosl - get potentional list of OSes that may installed on this PC");
        }
    }
}
