using System.Diagnostics;
using evanslib;

top:;

Evanslib.Print("What would you like?");

//Repond with "Date", "Military time", "US time", or "All"



string question = Evanslib.Input();

if (question == "All") {
    string bob = Evanslib.dateTime();
    Evanslib.Print(bob);
    Evanslib.Exit();
    goto top;
}

if (question == "Date") {
    string bobb = Evanslib.date();
    Evanslib.Print(bobb);
    Evanslib.Exit();
    goto top;
}

if (question == "Military time") {
    string bobbb = Evanslib.timeMT();
    Evanslib.Print(bobbb);
    Evanslib.Exit();
    goto top;
}

if (question == "US time") {
    string bobbbb = Evanslib.timeUT();
    Evanslib.Print(bobbbb);
    Evanslib.Exit();
    goto top;
}

if (question == "Month") {
    string bobbbbb = Evanslib.month();
    Evanslib.Print(bobbbbb);
    Evanslib.Exit();
    goto top;
}

else {
    Evanslib.exitError("Could not find what you were looking for, check it starts with a capital letter and that is is spelled correctly.", 1);
}