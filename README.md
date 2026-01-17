# Evan's Library to C#

> Evanslib for C# is a great, more user-friendly way to code in C#. The github will be more updated than the NuGet page, may be unstable or crash.

[![NuGet page](https://img.shields.io/badge/NuGet_page-1.3.7-blue.svg)](https://nuget.org/packages/evanslib)
[![Github page](https://img.shields.io/badge/Github_page-1.3.7-blue.svg)](https://github.com/Immagoeat/evanslibcsharp)

# Versions

## 1.3.7
Re-worked [FindX](README.md#findx), also changed the name from PercentIncrease to [PercentChange](README.md#percentchange).

## 1.3.6
Changed to let user handle errors instead of crashing the program and handling it in the library.

## 1.3.5
Added PercentIncrease, can be found in the [Math](README.md#math) section

## 1.3.4
Fixed errors with PercentOf

## 1.3.3
Added PercentOf, which can be found in [Math](README.md#math)

## 1.3.2
Added FindX and FindMultiX functions, check [Math](README.md#math) for more info

## 1.2.0
Added "Evansmath" which is in the [Math](README.md#math) section and can be found later in README

## 1.1.4
Changes how times work, now more optimised

## 1.1.2
Time and date functions now work differently (go to the "Time" section), and the name of the dictionary ammending changes slightly so it fits with the pattern of all other naming

## 1.1.1
In Evanslib version 1.1.1, error numbers are integers and no longer strings

## 1.1.0
Default benchmark, goes up to version 1.1.2


# How to setup
Run the following command in the terminal of your folder (can go up to 1.1.2)

    dotnet add package EvansLib

Then, enter "using evanslib;" in your code

# How to import
To import Evanslib into your project, you can use the function of

    using evanslib;

If you want to use Evansmath as well, you can use

    using evansmath;

You can use both if you need to, however they work as their own thing, and will decrease compile times while making my life easier when coding this

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
Evansmath is an easy and basic math system.

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

You can also do more complicated equasions, like

    Evansmath.FindX("17x - 42 + 8x - 13 - 6x + 91 - 25x + 4 + 39x - 7 - 18 + 2x - 11 = 54x - 120 + 6 - 31x + 9x - 14");


### PercentOf
You can find the percent value of a number with the following code.

    Evansmath.PercentOf("X% of Y");

### PercentChange
To find the percent of increase or decrease of a gap between numbers.

    Evansmath.PercentChange(OLDNUMBER, NEWNUMBER);

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
