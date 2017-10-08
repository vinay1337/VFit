using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PrevButton : MonoBehaviour {

    public GameObject screen;
    public GameObject NB;
    
    VideoPlayer player;
    float timer = 0;
    bool flag = false;
    public VideoClip[] videos = new VideoClip[3];
    //public int currSource = 0;

	// Use this for initialization
	void Start () {
        player = screen.GetComponent<VideoPlayer>();
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
            //NextButton.++;
            //if(currSource > 2)
            {
            //    currSource = 0;
            }
            //player.clip = videos[currSource];
            player.Play();
        }
    }
}
