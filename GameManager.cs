using UnityEngine;
 
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Debug.Log("*** Welcome to Farm Sim ***");
 
        Chicken nugget = new Chicken("Nugget", 10, 10);
        Cow milky = new Cow("Milky", 15, 15);
 
        
        Debug.Log($"= {nugget.Name} and {milky.Name} are living in the farm =");
 
    
        nugget.GetStatus();
        nugget.MakeSound();
        nugget.Sleep();
        nugget.GetStatus();
 
        milky.GetStatus();
        milky.MakeSound();
        milky.Moo();
        milky.GetStatus();
    }
 
  
    public string Name { get; protected set; }
    public int Hunger { get; protected set; }
    public int Happiness { get; protected set; }
 
    public virtual void GetStatus()
    {
        Debug.Log($"{Name} - Hunger: {Hunger}, Happiness: {Happiness}");
    }
 
    public virtual void MakeSound()
    {
        Debug.Log($"{Name} makes a sound!");
    }
 
    protected void AdjustHunger(int amount)
    {
        Hunger = Mathf.Max(0, Hunger + amount);
    }
 
    protected void AdjustHappiness(int amount)
    {
        Happiness = Mathf.Max(0, Happiness + amount);
    }
}
