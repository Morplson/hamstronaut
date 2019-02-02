using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOnQuitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnApplicationQuit()
    {

        PlayerPrefs.SetFloat("money", MoneyRun.getMoney());

    }
}
