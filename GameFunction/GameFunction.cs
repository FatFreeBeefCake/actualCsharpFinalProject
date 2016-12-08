using System;
using System.Collections.Generic;

public class GameFunction {

public static PlayerCreator player = new PlayerCreator(); 
public static GameStart start = new GameStart();
//public static List lists = new List();
 public static string AttackLine;

 public int numberOfHits = 3;

 public void Hit(){
     while (numberOfHits > 0)
     {
        Console.WriteLine ("You hit the beast!");
        numberOfHits--;
     }
 }
public static List<string> list1 = new List<string>(){"Hi","THis is a test","sup"};
public void ChangeList (){
    Console.WriteLine(list1);
}
public static int OfHits = 3;
public static void AttackFunction(){
    Console.WriteLine("You have encountered an enemy!");
    Console.WriteLine("Will you Attack or Run?");
    AttackLine = Console.ReadLine();
    if (AttackLine == "Attack")
    {
        Console.WriteLine("You have attacked the Enemy!");
        while(OfHits > 0){
            Console.WriteLine("You hit the beast!");
            OfHits--;
        }
        Console.WriteLine("You managed to kill the beast! but lost a little health!");
        Console.WriteLine(player.resolve - 10);
        //lists.ChangeList("Spencer", 9);
    } else if (AttackLine == "Run") {
        Console.WriteLine("This is real life, you cant run from your problems!");
        Console.WriteLine("The Monster attack from behind and you bleed out!");
    }
}
    public enum GamePlay {Start, Play, End, Died}

    public static GamePlay currentGamePlay = GamePlay.Start;

    
}