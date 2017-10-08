using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    float timer = 0;
    bool flag = false;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerStay(Collider other)
    {
        timer += Time.deltaTime;
        if (timer >= 1.5)
        {
            flag = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (flag)
        {
            flag = false;
            //Do stuff
        }
        timer = 0f;
    }
}
