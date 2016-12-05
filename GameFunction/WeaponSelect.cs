using System;

public class WeaponSelect{
public string name;
public int Power;
public string weaponName;

public void pickWeapon(){
    Console.WriteLine("Please pick your weapon!");
    Console.WriteLine("Sword, Bow, Staff");
    weaponName = Console.ReadLine();
    switch (weaponName){
        case "Sword":
        Console.WriteLine("A Sword The mightiest of weapons.");
        break;

        case "Bow":
        Console.WriteLine("Consider yourself a sniper?");
        break;

        case "Staff":
        Console.WriteLine("A fan of Explosions?");
        break;

        default:
        Console.WriteLine("just your fists? Good luck!");
        break;
    }
}


}