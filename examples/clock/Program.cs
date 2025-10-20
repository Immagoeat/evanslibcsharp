using System.Diagnostics;
using evanslib;
using System.Threading;
using System.Reflection.Metadata;


beginning:;



Evanslib.Print("Type '1' to see the time");

string input = Evanslib.Input();



if (input == "1"){

    //Clears the console then prints the time before restarting to program
    Console.Clear();
    string signa = Evanslib.dateTime;
    Evanslib.Print(signa);
    Thread.Sleep(2000);
    goto beginning;
}

else{
    //Loops back to beggining
    goto beginning;
}