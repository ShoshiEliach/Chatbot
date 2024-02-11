using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;

namespace Counter
{
    public class CounterPlugin : IPlugin
    {
        int lastCount = 0;
        string result = "";

        //string result;

        public static string _Id => "counter";
        public string Id => _Id;

        public PluginOutput Execute(PluginInput input)
        {
            if(input.PersistentData != null)
            {
              lastCount = int.Parse(input.PersistentData);
            }

            result = (lastCount + 1).ToString();

            return new PluginOutput(result, result);



        }
    }
}
