using System;
using System.Collections.Generic;


public class WeaponSelect{
public static GameFunction list = new GameFunction();
public static List<string> list1 = new List<string>(){"Hi","THis is a test","sup"};
public string name;
public int Power = 10;
public int Strength = 10;
public string weaponName;

    public void WeaponsMagic (){
        Console.WriteLine("Weapons Magical Abilities: ");
        string[] WeaponsMagic = new string[3];
        WeaponsMagic[0] = "Fire";
        WeaponsMagic[1] = "Lava";
        WeaponsMagic[2] = "Explosion";

        foreach (string item in WeaponsMagic){
            Console.WriteLine (item);
        }
    }
public void pickWeapon(){
    Console.WriteLine("Please pick your weapon!");
    Console.WriteLine("Sword, Bow, Staff");
    weaponName = Console.ReadLine();
    switch (weaponName){
        case "Sword":
        Console.WriteLine("A Sword The mightiest of weapons.");
        WeaponsMagic();
        Console.WriteLine("Power: " + (Power + 10));
        Console.WriteLine("Strength: " + (Strength + 15));
        break;

        case "Bow":
        Console.WriteLine("Consider yourself a sniper?");
        WeaponsMagic();
        Console.WriteLine("Power: " + (Power + 25));
        Console.WriteLine("Strength: " + (Strength + 20));
        break;

        case "Staff":
        Console.WriteLine("A fan of Explosions?");
        WeaponsMagic();
        Console.WriteLine("Power: " + (Power + 30));
        Console.WriteLine("Strength: " + (Strength + 10));
        break;

        default:
        Console.WriteLine("just your fists? Good luck!");
        Console.WriteLine("Power: " + (Power + 0));
        Console.WriteLine("Strength: " + (Strength + 0));
        break;
    }
}

}