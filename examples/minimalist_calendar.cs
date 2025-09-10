using evanslib;

Evanslib.Print("What would you like?");

//Repond with "Date", "Military time", "US time", or "All"

string question = Evanslib.Input();

if (question == "All") {
    Evanslib.currentDT();
}

if (question == "Date") {
    Evanslib.currentDate();
}

if (question == "Military time") {
    Evanslib.currentMT();
}

if (question == "US time") {
    Evanslib.currentUT();
}
    
else
{
    Evanslib.exitError("Could not find what you were looking for, check it starts with a capital letter and that is is spelled correctly.");
}