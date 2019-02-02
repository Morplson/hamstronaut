using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CageClick : MonoBehaviour {

    public GameObject someParticle;
    private Vector3 target;
    public int garbageTime = 50;

    void Start()
    {
        target = transform.position;
    }

    void OnMouseDown()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = transform.position.z;

        someParticle.transform.position = target;

        Destroy(Instantiate(someParticle), garbageTime * Time.deltaTime);

        MoneyRun.AddMoney(1);

    }


}
