using System.Reflection.Metadata;
using evanslib;



//Create the dictionary in which our users are stored
var users = Evanslib.Dict();

begining:;

Evanslib.Print("Sign up or log in?");
string option = Evanslib.Input();

//Only respond with 'Sign up' or 'Log in'. Anything else will be an error (see line 33)

if (option == "Sign up"){
    //Get username and password
    Evanslib.Print("Username: ");
    string newusername = Evanslib.Input();
    Evanslib.Print("Password: ");
    string newpassword = Evanslib.Input();
    //Ammend the dictionary
    Evanslib.ModifyDict(users, newusername, newpassword);
    goto begining;
}

if (option == "Log in"){
    //Get the details of their account
    Evanslib.Print("Username: ");
    string attemptusername = Evanslib.Input();
    Evanslib.Print("Password: ");
    string attemptpassword = Evanslib.Input();

    foreach (KeyValuePair<string, string> gyatt in users){
        if (attemptusername == gyatt.Key && attemptpassword == gyatt.Value){
            Evanslib.Print("Hello");
        }
    }

}



else {
    Evanslib.Error("There seems to be a misspelling. Please try again.", "1");
    goto begining;
}
