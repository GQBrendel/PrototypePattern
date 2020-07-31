public class Goblin : Monster
{
    public Goblin(int health, int speed) : base(health, speed)
    {
    }
    public override Monster Clone()
    {
        return new Goblin(Health, Speed);
    }
}