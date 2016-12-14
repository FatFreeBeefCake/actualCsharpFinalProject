using System;

public class LevelBase
{
    public static GameStart start = new GameStart();
    public static Return Coin = new Return();
    public int coins = 6;
    public static List lists = new List();

    public string[] Enemies = { " a Wolf", " a Dragon", " a Land Shark", " a Demon" };

    public void itemDrop()
    {
        Console.WriteLine("This Monster dropped: ");
        string[] items = new string[3];
        items[0] = "Bones";
        items[1] = "Guts";
        items[2] = "A bag of Coins";

        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
    public void coinCount()
    {
        for (int i = 0; i < coins; i++)
        {
            Console.WriteLine("Coins gathered: " + i);
        }
    }
    public void enter()
    {
        Console.WriteLine("Welcome to the land of Elkia!");
        Console.WriteLine("Your adventure starts down the stonepath.");
    }

    public void Encounter(int i)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("You have been attacked by" + Enemies[i]);
                GameFunction.AttackFunction();
                itemDrop();
                coinCount();
                Console.WriteLine("Total Coins: ");
                Coin.coinCount();
                Console.WriteLine("Please choose what items to take: ");
                lists.RunList();
                start.Play();
                break;

            case 1:
                Console.WriteLine("You have been attacked by" + Enemies[i]);
                GameFunction.AttackFunction();
                itemDrop();
                coinCount();
                Console.WriteLine("Total Coins: ");
                Coin.coinCount();
                Console.WriteLine("Please choose what items to take: ");
                lists.RunList();
                start.Play();
                break;

            case 2:
                Console.WriteLine("You have been attacked by" + Enemies[i]);
                GameFunction.AttackFunction();
                itemDrop();
                coinCount();
                Console.WriteLine("Total Coins: ");
                Coin.coinCount();
                Console.WriteLine("Please choose what items to take: ");
                lists.RunList();
                start.Play();
                break;

            case 3:
                Console.WriteLine("You have been attacked by" + Enemies[i]);
                if (Enemies[i] == "a Land Shark")
                {
                }
                GameStart.canPlay = false;
                break;

            default:
                Console.WriteLine("You have encountered no enemy.");
                start.Play();
                break;

        }

    }

}