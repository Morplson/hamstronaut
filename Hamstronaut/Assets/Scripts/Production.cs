using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Production : MonoBehaviour {

    public float ammount = 1;
    public float multiplyer = 1;
    public float durationMin = 300;
    public float durationMax = 600;

    public GameObject someParticle;
    public int garbageTime = 50;

    private GameObject go;

    private void Start()
    {
        if (ammount <= 0)
        {
            ammount = 1;
        }
        if (multiplyer <= 0.5)
        {
            multiplyer = 1;
        }

        go = this.gameObject;
        InvokeRepeating("ProCreate", Random.Range(durationMin, durationMax) * Time.deltaTime, Random.Range(durationMin, durationMax) * Time.deltaTime);
    }


    // Update is called once per frame
    void ProCreate () {
     

        someParticle.transform.position = go.transform.position;

        Destroy(Instantiate(someParticle), garbageTime * Time.deltaTime);

        MoneyRun.AddMoney(ammount*multiplyer);
    }
}
