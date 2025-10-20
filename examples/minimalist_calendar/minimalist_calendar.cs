using System.Diagnostics;
using evanslib;

top:;

Evanslib.Print("What would you like?");

//Repond with "Date", "Military time", "US time", or "All"



string question = Evanslib.Input();

if (question == "All") {
    string bob = Evanslib.dateTime();
    Evanslib.Print(bob);
    //Evanslib.Exit();
    goto top;
}

if (question == "Date") {
    Evanslib.Print(Evanslib.date);
    Evanslib.Exit();
    goto top;
}

if (question == "Military time") {
    Evanslib.Print(Evanslib.timeMT);
    Evanslib.Exit();
    goto top;
}

if (question == "US time") {
    Evanslib.Print(Evanslib.timeUT);
    Evanslib.Exit();
    goto top;
}

if (question == "Month") {
    Evanslib.Print(Evanslib.month);
    Evanslib.Exit();
    goto top;
}

else {
    Evanslib.exitError("Could not find what you were looking for, check it starts with a capital letter and that is is spelled correctly.", 1);
}