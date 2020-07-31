using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/MonstersSpritesScriptableObject", order = 1)]
public class MonstersSpritesScriptableObject : ScriptableObject
{
    [SerializeField] public Sprite _goblinSprite = null;
    [SerializeField] public Sprite _demonSprite = null;
    [SerializeField] public Sprite _skeletonSprite = null;

    public Sprite GetMonsterSprite(string monsterName)
    {
        switch (monsterName)
        {
            case "Goblin":
                return _goblinSprite;
                break;
            case "Demon":
                return _demonSprite;
                break;
            case "Skeleton":
                return _skeletonSprite;
                break;
        }
        Debug.LogError("Failed to find sprite for monster named " + monsterName);
        return null;
    }
}