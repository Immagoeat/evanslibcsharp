using evanslib;

Evanslib.Print("What would you like?");

//Repond with "Date", "Military time", "US time", or "All"

string question = Evanslib.Input();

if (question == "All")
{
    Evanslib.currentDT();
    goto end;
}

if (question == "Date")
{
    Evanslib.currentDate();
    goto end;
}

if (question == "Military time")
{
    Evanslib.currentTimeMT();
    goto end;
}

if (question == "US time")
{
    Evanslib.currentTimeUT();
    goto end;
}



else
{
    Evanslib.exitError("Could not find what you were looking for, check it starts with a capital letter and that is is spelled correctly.");
}
// You could also use 'Exit();' function, that will be used in login_sys.cs example.
end:;