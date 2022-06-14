using Assets.scripts.scene2;
using UnityEngine;

public class Mono2 : MonoBehaviour
{
    public GameEvents gameEvents;

    PresenterMono2 _presenter;
    // Start is called before the first frame update
    void Start()
    {
        _presenter = new PresenterMono2(this);

    }
}
