using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ResetButton : MonoBehaviour {

    public GameObject screen;
    VideoPlayer player;
    float timer = 0;
    bool flag = false;
    AudioSource click;

	// Use this for initialization
	void Start () {
        player = screen.GetComponent<VideoPlayer>();
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
            timer = 0;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (flag)
        {
            player.time = 0;
            click.Play();
            flag = false;
        }
    }
}
