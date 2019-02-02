using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyRun : MonoBehaviour {

    private static float cash;
    private Text text;

	// Use this for initialization
	void Start () {
        //text = GameObject.Find("MoneyDisPlay/Text").GetComponent<Text>();
        Debug.Log(cash);
        AddMoney(0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void AddMoney(float money)
    {
        Debug.Log(cash);
        MoneyRun.cash += money;
        GameObject.Find("MoneyDisplay/MoneyText").GetComponent<Text>().text = "Cash: " + cash + "$";
    }

    public static float getMoney()
    {
        return MoneyRun.cash;
    }

}
