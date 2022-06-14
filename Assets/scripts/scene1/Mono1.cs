using UnityEngine;

public class Mono1 : MonoBehaviour
{
    public GameEvents gameEvents;

    PresenterMono1 _presenter;
    // Start is called before the first frame update
    void Start()
    {
        _presenter = new PresenterMono1(this);

    }


}
