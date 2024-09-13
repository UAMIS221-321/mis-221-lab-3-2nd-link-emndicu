//main
string enjoyment = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoyment);
string game = GetGameRecommendation(stadium);
if (stadium == "error"){
    System.Console.WriteLine("Invalid enjoyment level entry");
}
else{
    DisplayStadiumDetails(stadium, game);
}




//main

static string GetEnjoymentLevel(){
    System.Console.WriteLine("Welcome to College Football Intro. What game enjoyment level would you like? (Boring / Average / Fun / Epic)");
    return Console.ReadLine();

}

static string GetStadiumRecommendation(string enjoymentLevel){
    if (enjoymentLevel.ToLower() == "boring"){
        return "Neyland Stadium";
    }
    else if (enjoymentLevel.ToLower() == "average"){
        return "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel.ToLower() == "fun"){
        return "Tiger Stadium";
    }
    else if (enjoymentLevel.ToLower() == "epic"){
        return "Saban Field at Bryant-Denny Stadium"; 
    }
    else {
        return "error";
    }
    
}

static string GetGameRecommendation(string stadium){
    if (stadium == "Neyland Stadium"){
        return "vs Kent State";
    }
    else if (stadium == "Jordan-Hare Stadium"){
        return "vs Kentucky";
    }
    else if (stadium == "Tiger Stadium"){
        return "vs Alabama";
    }
    else if (stadium == "Saban Field at Bryant-Denny Stadium"){
        return "vs Auburn";
    }
    else {
        return "error";
    }

}

static void DisplayStadiumDetails(string stadium, string game){
    System.Console.WriteLine($"You should go to {stadium} for the game {game}");

}