using System;

public class LevelBase{
    public bool entranceOpen = true;

    public string[] Enemies = {"Wolf" , "Dragon" , "Land Shark" , "Demon"};

    public void enter(){
        Console.WriteLine("Welcome to the land of Elkia!");
        Console.WriteLine("Your adventure starts down the stonepath.");
    }

    public void Encounter (int i){
        switch (i) {
        case 0:
        Console.WriteLine("You have been attacked by" + Enemies[i]);
        break;

        case 1:
        Console.WriteLine("You have been attacked by" + Enemies[i]);
        break;

        case 2:
        Console.WriteLine("You have been attacked by" + Enemies[i]);
        break;

        case 3:
        Console.WriteLine("You have been attacked by" + Enemies[i]);
        break;

        default:
        Console.WriteLine("You have encountered no enemy.");
            break;
                         
        }

    }
    
}