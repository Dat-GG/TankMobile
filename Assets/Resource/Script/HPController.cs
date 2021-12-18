using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;

public class HPController : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public float hpplayer;
    public Slider slider_hp;
    // Start is called before the first frame update
    void Start()
    {
        slider_hp.maxValue = hpplayer;
    }
    // Update is called once per frame
    void Update()
    {
        slider_hp.value = hpplayer;
    }
    public void Damage(float damage)
    {
        hpplayer -= damage;
    }
}
public class HP : SingletonMonoBehaviour<HPController>
{

}
