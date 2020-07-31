public class Spawner
{
    private Monster _monsterPrototype;

    public Spawner(Monster monsterPrototype)
    {
        this._monsterPrototype = monsterPrototype;
    }

    public Monster SpawnMonster()
    {
        return _monsterPrototype.Clone();
    }
}