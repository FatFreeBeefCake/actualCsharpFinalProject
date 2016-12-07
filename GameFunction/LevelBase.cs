using System;

public class LevelBase{
    public bool entranceOpen = true;   
    public static GameStart start = new GameStart(); 
    public static List lick = new List();

    public string[] Enemies = {" a Wolf" , " a Dragon" , " a Land Shark" , " a Demon"};

    public void enter(){
        Console.WriteLine("Welcome to the land of Elkia!");
        Console.WriteLine("Your adventure starts down the stonepath.");
    }

    public void Encounter (int i){
        switch (i) {
        case 0:
        Console.WriteLine("You have been attacked by" + Enemies[i]);
        GameFunction.AttackFunction();
        lick.RunList();
        start.Play();
        break;

        case 1:
        Console.WriteLine("You have been attacked by" + Enemies[i]);
        GameFunction.AttackFunction();
        lick.RunList();
        start.Play();
        break;

        case 2:
        Console.WriteLine("You have been attacked by" + Enemies[i]);
        GameFunction.AttackFunction();
        lick.RunList();
        start.Play();
        break;

        case 3:
        Console.WriteLine("You have been attacked by" + Enemies[i]);
        if (Enemies[i] == "a Land Shark"){
        }
        GameStart.canPlay = false;
        lick.RunList();
        break;

        default:
        Console.WriteLine("You have encountered no enemy.");
        start.Play();
            break;
                         
        }

    }
      
}