# Evan's Library to C#
Evanslib for C# is a great, more user-friendly way to code in C#

# Commands
Here you will see a list of all the commands in Evanslib

## Quality of life improvements
Some functions to save you a bit of work

### Print
The print function is exactly as it sounds. It prints. Here is an example of the command

    Print("STRING"); (CAn use a string or int)
### Input
This also takes an input, but you call it a bit differently than the print function.

    string/int VARNAME = Evanslib.Input();

## Time
Here are some functions for calling time

### Currint Date
This function displays the current date (by the system) in the terminal

    currentDate();

### Current Time (Military time [24 hour time])
Displays the 24 hr time in terminal

    currentTimeMT();

### Current Time (12 hour time)
Displays the 12 hr time in terminal

    currentTimeUT();

### Current Date and Time
Displays the 12 hr time and date in terminal

    currentDT(); (Both Date and military time)

## Dictionary functions
The Evanslib dictionary is easy to learn, in contrast to c#'s and its quick and easy

### Creating a dictionary
To create a dictionary, call

    var DICTIONARYNAME = Evanslib.Dict(); (Creates a dictionary w whatever name you assign)

### Adding to dictionary
To add a name and value to the dictionary, call

    Evanslib.ModifyDict(DICTIONARYNAME, "NAME", "VALUE"); (Creates an entry in the dictionary with a name and value, outputs "NAME: VALUE")

## Errors
Calling an error, exiting with an error, or exiting all together, it's easy with Evanslib

### Calling an error
To call an error, call

    Error("ERROR");

### Exiting with an error
In the case you need to exit with an error, call

    exitError("ERRORMESSAGE");

### Exiting
If you would like to exit altogether, you can call

    Exit();

# How to setup