using System;
using System.Collections.Generic;

public class GameFunction {

public static GameStart start = new GameStart();
 public static string AttackLine;
 public static int healthBar;

public static List<string> list1 = new List<string>(){"Hi","THis is a test","sup"};
private void ChangeList (string name, int Power){
    WeaponSelect newWeapon = new WeaponSelect();
}
public static void AttackFunction(){
    Console.WriteLine("You have encountered an enemy!");
    Console.WriteLine("Will you Attack or run?");
    AttackLine = Console.ReadLine();
    if (AttackLine == "Attack")
    {
        Console.WriteLine("You have attacked the Enemy!");
        Console.WriteLine("You managed to kill the beast! but lost a little health!");
        Console.WriteLine(healthBar - 10);
        start.Play();
    }
}
    public enum GamePlay {Start, Play, End}

    public static GamePlay currentGamePlay = GamePlay.Start;

    
}