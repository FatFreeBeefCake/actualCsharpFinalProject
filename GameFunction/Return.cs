using System;
public class Return
{

    int Health = 100;
    int Coiny;

    public void Healthy()
    {
        Health = Damage(Health);
        Console.WriteLine(Health);
    }

    public void coinCount(){
        Coiny = Coins(Coiny);
        Console.WriteLine(Coiny);

    }

    int Damage(int number)
    {
        int ret;
        ret = number - 20;
        return ret;
    }

    int Coins(int number){
        int rel;
        rel = number + 5;
        return rel;
    }

}