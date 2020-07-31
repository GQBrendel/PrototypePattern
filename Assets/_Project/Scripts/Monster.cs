using UnityEngine;

public abstract class Monster
{
    public string Name { get; }
    public int Attack { get; }
    public int Defense { get; }
    public Sprite Sprite { get; }

    public Monster(string name, int attack, int defense, Sprite sprite)
    {
        this.Name = name;
        this.Attack = attack;
        this.Defense = defense;
        this.Sprite = sprite;
    }

    public abstract Monster Clone();
}
