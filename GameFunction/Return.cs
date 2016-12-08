using System;
public class Return{

int Health = 100;

void Start(){
Health = Damage(Health);
Console.WriteLine(Health);
}

int Damage (int number){
    int ret;
    ret = number * 2;
    return ret;
}

}