using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace CountDown
{
    public class CountDownPlugin : IPluginWithScheduler
    {
        int interval = 0;
        IScheduler _scheduler;

        public CountDownPlugin(IScheduler scheduler) => _scheduler = scheduler;

        public static string _Id = "count-down";
        public string Id => _Id;

        public PluginOutput Execute(PluginInput input)
        {   if(input.Message!="")
                interval = int.Parse(input.Message);
            _scheduler.Schedule(TimeSpan.FromSeconds(interval), Id, "");
            return new PluginOutput("Countdown started.");

        }

        public void OnScheduler(string data)
        {
            Console.WriteLine("Fired.");
        }
    }
}
