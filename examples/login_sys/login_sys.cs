using evanslib;

Evanslib.Print("Sign up or log in?");
string option = Evanslib.Input();

//Only respond with 'Sign up' or 'Log in'. Anything else will be an error (see line)

if (option == "Sign up"){
    Evanslib.Print("Hello World!");
}