using System;
using System.Collections.Generic;
using Cintio;


namespace AnotherCSharpRepl
{
    
    public class InputErrorEventArgs : EventArgs
    {
        public InputErrorEventArgs(string s) { error = s; }
        public string error { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var prompt = "c#> ";
            List<string> compList = new List<string>();
            CSharpEvaluator eval = new CSharpEvaluator();
            var startupMsg = "Another C# REPL v 1.0.0";
            InteractivePrompt.Run(
                ((strCmd, listCmd, completions) =>
                {
                    foreach (var c in strCmd.Split(' '))
                        if (!completions.Contains(c))
                            completions.Add(c);
                    return eval.HandleCmd(strCmd) + Environment.NewLine;
                }), prompt, startupMsg, compList);
        }
    }
}
