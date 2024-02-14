using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace Hexadecimal
{
    public class HexadecimalPlugin : IPlugin
    {
        public static string _Id => "Hexadecimal";
        public string Id => _Id;
        string hexValue = "";

       

        /*public HexadecimalPlugin(IScheduler scheduler) => _scheduler = scheduler;

        public static string _Id = "count-down";
        public string Id => _Id;*/

        public PluginOutput Execute(PluginInput input)
        {
            if (input.Message == "")
            {
                input.Callbacks.StartSession();
                return new PluginOutput("Count words started. Enter 'Exit' to stop.");
            }
            else if (input.Message.ToLower() == "exit")
            {
                input.Callbacks.EndSession();
                return new PluginOutput("Count words stopped.");
            }
            else 
            {
                hexValue = int.Parse(input.Message).ToString("X");
                return new PluginOutput(hexValue);
            }
                 

        }

       
    }
}
