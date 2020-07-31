using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button _goblinButton = null;
    [SerializeField] private Button _demonButton = null;
    [SerializeField] private Button _skeletonButton = null;

    public delegate void SpawnButtonsHandler();
    public SpawnButtonsHandler OnGoblinButtonClicked;
    public SpawnButtonsHandler OnDemonButtonClicked;
    public SpawnButtonsHandler OnSkeletonButtonClicked;

    void Start()
    {
        _goblinButton.onClick.AddListener(delegate { OnGoblinButtonClicked?.Invoke(); });
        _demonButton.onClick.AddListener(delegate { OnDemonButtonClicked?.Invoke(); });
        _skeletonButton.onClick.AddListener(delegate { OnSkeletonButtonClicked?.Invoke(); });
    }
}
