using System.Reflection.Metadata;
using evanslib;

begining:;

Evanslib.Print("Sign up or log in?");
string option = Evanslib.Input();

//Only respond with 'Sign up' or 'Log in'. Anything else will be an error (see line)

if (option == "Sign up"){
    //Get username and password
    Evanslib.Print("Username: ");
    string newusername = Evanslib.Input();
    Evanslib.Print("Password: ");
    string newpassword = Evanslib.Input();
    //Create dictionary
    var users = Evanslib.Dict();
    Evanslib.ModifyDict(users, newusername, newpassword);
    goto begining;
}


else {
    Evanslib.Error("There seems to be a misspelling. Please try again.");
    goto begining;
}
