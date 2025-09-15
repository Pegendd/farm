using UnityEngine;

public class Cow : GameManager
{
    public float Milk { get; private set; }

    public Cow(string name, int hunger, int happiness)
    {
        Name = name;
        Milk = 0;
        AdjustHunger(hunger);
        AdjustHappiness(happiness);
    }

    public override void GetStatus()
    {
        Debug.Log($"{Name} -> Hunger: {Hunger}, Happiness: {Happiness}, Milk: {Milk}");
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Moo!");
    }

    public void Moo()
    {
        Debug.Log($"{Name} says MooMooMoo!");
        AdjustHunger(15);
        AdjustHappiness(15);
    }
}
