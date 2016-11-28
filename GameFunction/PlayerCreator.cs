using System;

public class PlayerCreator{

public string[] RaceType = {"Human" , "Elf", "orc" , "Dwarf"};
public string yourGender;
public string name;

public void whatGender(){
    Console.WriteLine("Please choose a gender");
    Console.WriteLine("Male/Female");
    yourGender = Console.ReadLine();

    }
    public void pickRace(){
    Console.WriteLine("What race would you like to be?");
    Console.WriteLine("Human, Elf, orc, Dwarf");
    Console.ReadLine(RaceType);
    
     switch(RaceType) {
         case "Human":
         break;

         case "Elf":
         break;

         case "orc":
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
        Console.ReadLine(name);
        Console.WriteLine("Welcome " + name + " The " + RaceType);
    }
}