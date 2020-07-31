using UnityEngine;

public class Goblin : Monster
{
    public Goblin(string name, int attack, int defense, Sprite sprite) : base(name, attack, defense, sprite)
    {
    }
    public override Monster Clone()
    {
        return new Goblin(Name, Defense, Attack, Sprite);
    }
}