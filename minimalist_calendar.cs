using evanslib;


Evanslib.Print("What would you like?");

//Repond with "Date", "Military time", "US time", or "All"

string question = Evanslib.Input();

if (question == "All")
{
    Evanslib.currentDT();
}

if (question == "Date")
{
    Evanslib.currentDate();
}

if (question == "Military time")
{
    Evanslib.currentDT();
}