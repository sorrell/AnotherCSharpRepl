# ACSR (Another CSharp Repl)
The purpose of this project is to show how quickly and easily a REPL can be created with the help of InteractivePrompt, giving 
the dev full access to a command history, and any completions the dev would like to pass along.  It also shows how to capture the error output of the Mono `Evaluator` object - we catch the missing namespace errors to automatically run a `using <namespace>` command for the user.

In this example, we pass the whole command back into the completion list (not just the LHS).

Credit to http://www.samuelbosch.com/2015/11/simple-lightweight-csharp-repl.html


![image](http://cint.io/acsrOverview.gif)
