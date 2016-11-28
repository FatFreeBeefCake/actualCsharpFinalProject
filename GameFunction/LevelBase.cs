using System;

public class LevelBase{

    public string[] Enemies = {"Wolf" , "Dragon" , "Land Shark" , "Demon"};

    public void enter(){
        Console.WriteLine();

    }

    public void Encounter (int i){
        switch (i) {
        case 0:
        break;

        case 1:
        break;

        case 2:
        break;

        case 3:
        break;

        default:
        Console.WriteLine("You have encountered no enemy.");
            break;
                         
        }

    }
    
}