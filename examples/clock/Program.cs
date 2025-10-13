using System.Diagnostics;
using evanslib;
using System.Threading;


beginning:;



Evanslib.Print("Type '1' to see the time");

string input = Evanslib.Input();



if (input == "1"){
    //Creating time function (dateTime used in this example)
    var time = Evanslib.dateTime;

    //Clears the console then prints the time before restarting to program
    Console.Clear();
    Evanslib.Print(time);
    Thread.Sleep(2000);
    goto beginning;
}

else{
    //Loops back to beggining
    goto beginning;
}