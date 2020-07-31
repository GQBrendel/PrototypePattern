using UnityEngine;

public class Demon : Monster
{
    public Demon(string name, int attack, int defense, Sprite sprite) : base(name, attack, defense, sprite)
    {
    }
    public override Monster Clone()
    {
        return new Demon(Name, Defense, Attack, Sprite);
    }
}
