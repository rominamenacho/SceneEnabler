using Assets.scripts.scene3;
using UnityEngine;

public class Mono3 : MonoBehaviour
{
    public GameEvents gameEvents;

    PresenterMono3 _presenter;
    // Start is called before the first frame update
    void Start()
    {
        _presenter = new PresenterMono3(this);

    }
}
