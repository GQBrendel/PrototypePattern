using UnityEngine;

public class PrototypeManager : MonoBehaviour
{
    private Monster _goblinPrototype;
    private Spawner _goblinSpawner;

    void Start()
    {
        _goblinPrototype = new Goblin(15, 3);
        _goblinSpawner = new Spawner(_goblinPrototype);
        _goblinSpawner.SpawnMonster();
    }
}