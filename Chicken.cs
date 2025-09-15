using UnityEngine;

public class Chicken : GameManager
{
    public int Eggs { get; private set; }

    public Chicken(string name, int hunger, int happiness)
    {
        Name = name;
        Eggs = 0;
        AdjustHunger(hunger);
        AdjustHappiness(happiness);
    }

    public override void GetStatus()
    {
        Debug.Log($"{Name} the Chicken - Hunger: {Hunger}, Happiness: {Happiness}, Eggs: {Eggs}");
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Cluck!");
    }

    public void Sleep()
    {
        Debug.Log($"{Name} is sleeping.");
        AdjustHunger(10);
        AdjustHappiness(10);
    }
}
