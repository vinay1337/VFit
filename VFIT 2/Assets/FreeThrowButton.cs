﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeThrowButton : MonoBehaviour {

    float timer = 0;
    bool flag = false;
    AudioSource click;

	// Use this for initialization
	void Start () {
        click = GetComponent<AudioSource>();
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
            click.Play();
            Application.LoadLevel("Throwing test");
        }
        timer = 0f;
    }
}