using System;
using System.Runtime.InteropServices;
using ChakraHost.Hosting;
// wrapper namespace

public class HelloWorld
{
    private static void Main()
    {
        JavaScriptRuntime runtime;
        JavaScriptContext context;
        var currentSourceContext = JavaScriptSourceContext.FromIntPtr(IntPtr.Zero);
        JavaScriptValue result;

        // Your script, try replace the basic hello world with something else
        var script = @"
                class Greeter {
                    hello() { return 'コンニチハ!'; }
                }
                new Greeter().hello();
            ";

        // Create a runtime. 
        Native.JsCreateRuntime(JavaScriptRuntimeAttributes.None, null, out runtime);

        // Create an execution context. 
        Native.JsCreateContext(runtime, out context);

        // Now set the execution context as being the current one on this thread.
        Native.JsSetCurrentContext(context);

        // Run the script.
        Native.JsRunScript(script, currentSourceContext++, "", out result);

        // Convert your script result to String in JavaScript; redundant if your script returns a String
        JavaScriptValue resultJSString;
        Native.JsConvertValueToString(result, out resultJSString);

        // Project script result in JS back to C#.
        IntPtr resultPtr;
        UIntPtr stringLength;
        Native.JsStringToPointer(resultJSString, out resultPtr, out stringLength);

        var resultString = Marshal.PtrToStringUni(resultPtr);
        Console.WriteLine(resultString);

        // Dispose runtime
        Native.JsSetCurrentContext(JavaScriptContext.Invalid);
        Native.JsDisposeRuntime(runtime);

        Console.ReadLine();
    }
}