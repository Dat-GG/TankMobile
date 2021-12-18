using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class TankController : MoveController
{
    public GameObject BodyTank;
    public GameObject gun;
    public Transform Transhoot;
    public string opponent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void Move(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            BodyTank.transform.up = direction;
        }
        base.Move(direction);
    }
    protected virtual void RotateGun(Vector3 Gundirection)
    {
        gun.gameObject.transform.up = Gundirection;
    }
    protected virtual void Shoot()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == opponent)
        {
            Destroy(gameObject);
        }
    }
}