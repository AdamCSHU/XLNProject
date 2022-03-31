function getBotResponse(input) {
    if (input == "I have a network problem"){
        return "What kind of severity is your network problem? If it's a frequent/simple problem, please visit our help me page.";
    }

    // Simple responses
    if (input == "hello") {
        return "Hello there!";
    } else if (input == "goodbye") {
        return "Talk to you later!";
    }  else if (input == "i want help"){
        return "What would you like help with?";
        getHelp(input);
    }else{
        return "Input not recognised, please try again.";
    }
}

