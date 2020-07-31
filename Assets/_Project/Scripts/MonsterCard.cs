using UnityEngine;
using UnityEngine.UI;

public class MonsterCard : MonoBehaviour
{
    [SerializeField] private Text _nameText = null;
    [SerializeField] private Text _attackText = null;
    [SerializeField] private Text _defenseText = null;
    [SerializeField] private Image _monsterImage = null;
    [Space]
    [SerializeField] private float _verticalSpeed = 0f;

    private float _verticalPostion;

    private void Awake()
    {
        _verticalPostion = transform.position.y;
    }

    private void Update()
    {
        _verticalPostion += Time.deltaTime * _verticalSpeed;
        transform.position = new Vector2(transform.position.x, _verticalPostion);

        if(transform.localPosition.y > 800)
        {
            Destroy(gameObject);
        }
    }

    public void Draw(Monster monster)
    {
        _nameText.text = monster.Name;
        _monsterImage.sprite = monster.Sprite;
        _attackText.text = "Atk: " + monster.Attack.ToString();
        _defenseText.text = "Def: " + monster.Defense.ToString();
    }
}