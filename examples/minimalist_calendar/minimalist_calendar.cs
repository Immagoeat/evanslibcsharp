using evanslib;

Evanslib.Print("What would you like?");

//Repond with "Date", "Military time", "US time", or "All"

string question = Evanslib.Input();

if (question == "All") {
    Evanslib.Print(Evanslib.dateTime);
    Evanslib.Exit();
}

if (question == "Date") {
    Evanslib.Print(Evanslib.date);
    Evanslib.Exit();
}

if (question == "Military time") {
    Evanslib.Print(Evanslib.timeMT);
    Evanslib.Exit();
}

if (question == "US time") {
    Evanslib.Print(Evanslib.timeUT);
    Evanslib.Exit();
}

if (question == "Month") {
    Evanslib.Print(Evanslib.month);
    Evanslib.Exit();
}

else {
    Evanslib.exitError("Could not find what you were looking for, check it starts with a capital letter and that is is spelled correctly.", 1);
}