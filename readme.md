# Week 5 course

This week we will explore `unit testing` a new NuGet package [KP.ConverterLibrary](https://www.nuget.org/packages/KP.ConverterLibrary/) for working with numeric types conversions.

Many of these extensions are rarely needed while when they are needed they can be indispensable. 

:small_orange_diamond: Several of the extension methods 

- Several of the extension methods have gotchas that may not be realized until performing unit test on them.
- Different ways to properly test if an exception is meant to be thrown

![image](assets/ErrorChoices.png)

- Some `unit test methods` are `pre-done` to save time while the majority we will write at class time.



| Answers  |
| :--- |
| If you get stuck on any exercise, the [following project](https://github.com/karenpayneoregon/kp-converters/tree/master/CoreUnitTestProject) `in a GitHub repositor` has full solutions. |

</br> </br>

| Check this out  |
| :--- |
| ![img](assets/karenGitIo.png) |


## NorthWindConnections

This utility test if the current user can connect to the following database which I've offered to the service desk to use an alternate location `C:\OED\Dotnetland\VS2019\NorthData` for working with a local SQL-Server database.

If they are open to this a developer can run this utility directly inside of Visual Studio or from Windows Explorer.

We will not be going over the code in this project but if time permits each developer should at least check the code out.

Although this code is extremely simple for experienced developers, this is not the case for novice developers. 
The average non-professional (and even some professional) developer/coder have little to no expertise working with 
[delegates](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/) and 
[events](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/) at any level 
where this code does use events. Check out this [Pluralsight course](https://app.pluralsight.com/library/courses/csharp-events-delegates/table-of-contents).

Delegate/event

```csharp
public delegate void OnTaskCompleted(Task sender);
public static event OnTaskCompleted Completed;
```

**Task**

- Does database exists?
- Can connect to database?
- Can read from database?

![image](NorthWindConnections/assets/NorthScreen.png)

| Visual Studio on S drive if unable to get from GitHub  |
| :--- |
| S:\APPLICATIONS\VisualStudioTraining\VisualStudioTraining-week5 |
