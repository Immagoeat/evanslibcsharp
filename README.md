# Evan's Library to C#
Evanslib for C# is a great, more user-friendly way to code in C#
The github will be more updated than the NuGet page, may be unstable or crash.
Next version is being worked on and will include 'FindX' and 'FindMultiX' functions. These can find a missing value in an equasion. FindX is in the 1.2.1-pre and FindMultiX still doesn't work.

# Versions

## 1.2.0
Newest version, added "Evansmath" which is in the [Math](README.md#math) section and can be found later in README

## 1.1.4
Latest version, changes how times work, now more optimised

## 1.1.2
Time and date functions now work differently (go to the "Time" section), and the name of the dictionary ammending changes slightly so it fits with the pattern of all other naming

## 1.1.1
In Evanslib version 1.1.1, error numbers are integers and no longer strings

## 1.1.0
Default benchmark, goes up to version 1.1.2

# Commands
Here you will see a list of all the commands in Evanslib

## Quality of life improvements
Some functions to save you a bit of work

### Print
The print function is exactly as it sounds. It prints. Here is an example of the command

    Print("STRING"); (Can use a string or int)
### Input
This also takes an input, but you call it a bit differently than the print function.

    string/int VARNAME = Evanslib.Input();

## Time
Here are some functions for calling time (you can only print for now)

### Current Date
This function displays the current date (by the system) in the terminal

    var VARNAME = Evanslib.date();
    Evanslib.Print(VARNAME);

### Current Time (Military time [24 hour time])
Displays the 24 hr time in terminal

    var VARNAME = Evanslib.timeMT();
    Evanslib.Print(VARNAME);

### Current Time (12 hour time)
Displays the 12 hr time in terminal

    var VARNAME = Evanslib.timeUT();
    Evanslib.Print(VARNAME);

### Current Month
Displays the 3 letter code for the month

    var VARNAME = Evanslib.month();
    Evanslib.Print(VARNAME);

### Current Date and Time
Displays the 12 hr time and date in terminal

    var VARNAME = Evanslib.dateTime();
    Evanslib.Print(VARNAME);

## Dictionary functions
The Evanslib dictionary is easy to learn, in contrast to c#'s and its quick and easy

### Creating a dictionary
To create a dictionary, call

    var DICTIONARYNAME = Evanslib.Dict(); (Creates a dictionary w whatever name you assign)

### Adding to dictionary
To add a name and value to the dictionary, call

    Evanslib.modifyDict(DICTIONARYNAME, "NAME", "VALUE"); (Creates an entry in the dictionary with a name and value, outputs "NAME: VALUE")

## Math
Evansmath is an easy and basic math system. This will be updated more later on but it's a good place to start

### Adding
To add, you would

    Evansmath.Add(NUM1, NUM2);

### Subtracting
To subtract

    Evansmath.Subtract(NUM1, NUM2);

### Multiplying
To multiply, 

    Evansmath.Multply(NUM1, NUM2);

### Dividing
Finally, to divide

    Evansmath.Divide(NUM1, NUM2);

### FindX
You can now find the value of 'x'. You can add, subtract, multiply, or divide.

    Evansmath.FindX("x + 12 = 14");

### FindMultiX
You can solve a problem like ax + b = cx + d, but any kind of sign works.

    Evansmath.FindMultiX("2x + 3 = 8x - 11");

## Errors
Calling an error, exiting with an error, or exiting all together, it's easy with Evanslib

### Calling an error
To call an error, call

    Error("ERROR", ERROR_NUMBER);

### Exiting with an error
In the case you need to exit with an error, call

    exitError("ERRORMESSAGE", ERROR_NUMBER);

### Exiting
If you would like to exit altogether, you can call

    Exit();

# How to setup
Run the following command in the terminal of your folder (can go up to 1.1.2)

    dotnet add package EvansLib --version 1.1.0

Then, enter "using Evanslib;" in your code
