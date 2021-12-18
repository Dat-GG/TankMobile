using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;

public class GameController : MonoBehaviour
{
    public Text score;
    public float score_number;
    public Text level;
    public int level_number;
    public GameObject location;
    public GameObject newenemy;

    void Start()
    {
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, Getnotify);
    }
    private void Getnotify(object data)
    {
        Instantiate(newenemy, location.transform.position, location.transform.rotation);
    }
    private void OnDestroy()
    {
        Observer.Instance.RemoveObserver(TOPICNAME.ENEMYDESTROY, Getnotify);
    }
    void Update()
    {
        score.text = "Points: " + score_number.ToString();
        level.text = "Level: " + level_number.ToString();
    }
}
public class GameCtrl : SingletonMonoBehaviour<GameController>
{

}
