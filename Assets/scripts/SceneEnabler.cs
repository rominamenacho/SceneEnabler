using Assets.scripts;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SceneEnabler : MonoBehaviour
{

    public GameEvents gameEvents;

    public event Action EnableMono1 = () => { };
    public event Action EnableMono2 = () => { };
    public event Action EnableMono3 = () => { };

    [SerializeField] public Button ButtonEnableScene2;
    [SerializeField] public Button ButtonEnableScene3;
    [SerializeField] public Button ButtonEnableScene1;

    [SerializeField] public GameObject scene1;
    [SerializeField] public GameObject scene2;
    [SerializeField] public GameObject scene3;

    SceneEnablerPresenter _presenter;

    // Start is called before the first frame update
    void Start()
    {
        _presenter = new SceneEnablerPresenter(this);
        AddListener();
    }

    private void AddListener()
    {
        ButtonEnableScene2.onClick.AddListener(() =>
        {
            EnableMono2.Invoke();
        });

        ButtonEnableScene3.onClick.AddListener(() =>
        {
            EnableMono3.Invoke();
        });

        ButtonEnableScene1.onClick.AddListener(() =>
        {
            EnableMono1.Invoke();
        });
    }

    public void ActiveScene1()
    {

        scene3.SetActive(false);
        scene1.SetActive(true);

    }
    public void ActiveScene2()
    {

        scene1.SetActive(false);
        scene2.SetActive(true);
    }
    public void ActiveScene3()
    {
        scene2.SetActive(false);
        scene3.SetActive(true);

    }

}
