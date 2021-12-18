using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class BulletController : MoveController, IceSkill
{
    public int time;
    public GameObject smoke;
    public GameObject prebIce;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(transform.up);
        bulletEx();
    }
    void bulletEx()
    {   
        time += 1;
        if (time == 20)
        {
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Ice(100, prebIce);
            PoolingObject.DestroyPooling<BulletController>(this);
            return;
        }   
    }
    public void Ice(int dameff, GameObject Ice)
    {
        Instantiate(Ice, this.gameObject.transform.position, this.gameObject.transform.rotation);
        damage = dameff;
    }
}
