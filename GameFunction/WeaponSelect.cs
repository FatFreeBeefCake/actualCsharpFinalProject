using System;

public class WeaponSelect{
public string name;
public int Power;
public string weaponName;

public void pickWeapon(){
    switch (weaponName){
        case "Sword":
        break;

        case "Bow":
        break;

        case "Staff":
        break;

        default:
        Console.WriteLine("just your fists? Good luck!");
        break;
    }
}


}