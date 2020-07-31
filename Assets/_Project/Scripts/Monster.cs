public abstract class Monster
{
    protected int Speed { get; }
    protected int Health { get; }

    public Monster(int health, int speed)
    {
        this.Speed = speed;
        this.Health = health;
    }

    public abstract Monster Clone();
}
