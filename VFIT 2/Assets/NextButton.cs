using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class NextButton : MonoBehaviour {

    public GameObject screen;
    AudioSource click;
    VideoPlayer player;
    float timer = 0;
    bool flag = false;
    public VideoClip[] videos = new VideoClip[3];
    public int currSource = 0;

	// Use this for initialization
	void Start () {
        player = screen.GetComponent<VideoPlayer>();
        click = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("NEXT_ENTERED");
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
        //Debug.Log("NEXT_EXITED");

        if (flag)
        {
            flag = false;
            currSource++;
            if(currSource > 2)
            {
                currSource = 0;
            }
            player.clip = videos[currSource];
            player.Play();
            click.Play();
        }
    }
}
