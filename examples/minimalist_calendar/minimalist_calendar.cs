using evanslib;

Evanslib.Print("What would you like?");

//Repond with "Date", "Military time", "US time", or "All"

string question = Evanslib.Input();

if (question == "All") {
    Evanslib.currentDT();
    Evanslib.Exit();
}

if (question == "Date") {
    Evanslib.currentDate();
    Evanslib.Exit();
}

if (question == "Military time") {
    Evanslib.currentTimeMT();
    Evanslib.Exit();
}

if (question == "US time") {
    Evanslib.currentTimeUT();
    Evanslib.Exit();
}



else {
    Evanslib.exitError("Could not find what you were looking for, check it starts with a capital letter and that is is spelled correctly.", "1");
}

// You could also use 'Exit();' function, that will be used in login_sys.cs example.
end:;