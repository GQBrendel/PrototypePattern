using UnityEngine;

public class PrototypeManager : MonoBehaviour
{
    [SerializeField] private UIManager _uIManager = null;
    [SerializeField] private MonstersSpritesScriptableObject _monstersSprites = null;
    [SerializeField] private GameObject _monsterCardPrefab = null;
    [SerializeField] private Transform _uiSpawnArea = null;

    private Monster _monsterPrototype;
    private Spawner _goblinSpawner;
    private Spawner _demonSpawner;
    private Spawner _skeletonSpawner;

    private float _currentHorizontalSpawnPosition = -720f;

    private void Awake()
    {
        _uIManager.OnGoblinButtonClicked += HandleSpawnGoblin;
        _uIManager.OnDemonButtonClicked += HandleSpawnDemon;
        _uIManager.OnSkeletonButtonClicked += HandleSpawnSkeleton;

        _monsterPrototype = new Goblin("Goblin", 150, 453, _monstersSprites.GetMonsterSprite("Goblin"));
        _goblinSpawner = new Spawner(_monsterPrototype);

        _monsterPrototype = new Demon("Demon", 666, 874, _monstersSprites.GetMonsterSprite("Demon"));
        _demonSpawner = new Spawner(_monsterPrototype);

        _monsterPrototype = new Skeleton("Skeleton", 999, 123, _monstersSprites.GetMonsterSprite("Skeleton"));
        _skeletonSpawner = new Spawner(_monsterPrototype);
    }

    private void CalculateHorizontalPostion()
    {
        if(_currentHorizontalSpawnPosition < 720f)
        {
            _currentHorizontalSpawnPosition += 360f;
            if(_currentHorizontalSpawnPosition > 720f)
            {
                _currentHorizontalSpawnPosition = 720f;
            }
        }
        else
        {
            _currentHorizontalSpawnPosition = -720;
        }
    }

    private void HandleSpawnGoblin()
    {
        Monster spawnedMonster = _goblinSpawner.SpawnMonster();
        SpawnMonster(spawnedMonster);
    }

    private void HandleSpawnDemon()
    {
        Monster spawnedMonster = _demonSpawner.SpawnMonster();
        SpawnMonster(spawnedMonster);
    }

    private void HandleSpawnSkeleton()
    {
        Monster spawnedMonster = _skeletonSpawner.SpawnMonster();
        SpawnMonster(spawnedMonster);
    }

    private void SpawnMonster(Monster monster)
    {
        GameObject monsterInstance = Instantiate(_monsterCardPrefab, _uiSpawnArea);
        monsterInstance.transform.localPosition = new Vector3(_currentHorizontalSpawnPosition, 0, 0);   
        MonsterCard monsterCard = monsterInstance.GetComponent<MonsterCard>();
        monsterCard.Draw(monster);
        CalculateHorizontalPostion();
    }

    private void OnDestroy()
    {
        _uIManager.OnGoblinButtonClicked -= HandleSpawnGoblin;
        _uIManager.OnDemonButtonClicked -= HandleSpawnDemon;
        _uIManager.OnSkeletonButtonClicked -= HandleSpawnSkeleton;
    }
}