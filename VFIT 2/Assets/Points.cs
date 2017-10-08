using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {

    Transform transform;
    Quaternion pos1;
    Quaternion pos2;
    float timer;
    bool alt = false;
    float rawScore;
    public int score = 0;

    // Use this for initialization
    void Start () {
        transform = GetComponent<Transform>();
        pos1 = transform.rotation;
        pos2 = transform.rotation;
        timer = 0f;
        rawScore = 0f;
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if(timer >= 0.1f)
        {
            timer = 0f;
            alt = !alt;
            if (alt)
            {
                pos1 = transform.rotation;
            }
            else
            {
                pos2 = transform.rotation;
            }
        }

        rawScore = Quaternion.Angle(pos1, pos2);
        score += (int)rawScore / 20;
	}
}
