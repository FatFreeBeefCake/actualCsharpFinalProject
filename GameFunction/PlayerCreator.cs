using System;

public class PlayerCreator{

public string raceType;
public string yourGender;
public string name;

public void whatGender(){
    Console.WriteLine("Please choose a gender");
    Console.WriteLine("Mr./Mrs.");
    yourGender = Console.ReadLine();

    }
    public void pickRace(){
    Console.WriteLine("What race would you like to be?");
    Console.WriteLine("Human, Elf, Orc, Dwarf");
    raceType = Console.ReadLine();
    
     switch(raceType) {
         case "Human":
         break;

         case "Elf":
         break;

         case "Orc":
         break;

         case "Dwarf":
         break;

         default:
         Console.WriteLine("this is not a valid Race!");
         break;

     }
    }
    public void whatsYourName(){
        Console.WriteLine("What is your Player name?");
        name = Console.ReadLine();
        Console.WriteLine("Welcome " + yourGender +" "+ name + " The " + raceType);
    }
}