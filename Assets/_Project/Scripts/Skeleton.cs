using UnityEngine;

public class Skeleton : Monster
{
    public Skeleton(string name, int attack, int defense, Sprite sprite) : base(name, attack, defense, sprite)
    {
    }
    public override Monster Clone()
    {
        return new Skeleton(Name, Defense, Attack, Sprite);
    }
}
