# What is this?

A simple, readable and thread safe runtime and debug logging implementation.

### Features
- Automatic Console allocation for non-Console apps in Debug mode
- Clear log format with configurable padding
- Thread safe (normal locking)
- Easy to use

Note: Weather the applications is currently running in debug mode is determined by `#if DEBUG ... #endif` and the `[Conditional("DEBUG")]` method attribute, which prevents code form getting compiled into release binaries.

# Sample Debug Output

![Image](./readmeAssets/debug_cli_preview.png)

# Sample Logfile Output

![Image](./readmeAssets/sampleLogFile.png)

# Getting Started

1. Copy the `Logging` directory into your solution
2. Added `using BSS.Logging;` to your `.cs` file to import the namespace
3. Initialize the Log Class with `Log.Initialize();`, (you may want to pass in a path to the log output directory and/or the padding width)

Now you can call for example:
>	Log.FastLog("Info message from ThreadPool", LogSeverity.Info, "ThreadPool");

This will output to the log file, and in debug mode to the console.

Or to just write to the console in debug mode:
>	xDebug.WriteLine("direct console write");

---

Note: You can manually invoke the initialization of the `xDebug` class, but this should normally not be necessary (static constructor)
>	if (!xDebug.IsInitialized)

This should <u>allways</u> return `true`.