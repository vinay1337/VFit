using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour {

    public GameObject LHand;
    public GameObject RHand;
    public int finalScore = 0;
    TextMesh textMesh;

	// Use this for initialization
	void Start () {
        textMesh = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        finalScore = (LHand.GetComponent<Points>().score + RHand.GetComponent<Points>().score) / 1;
        textMesh.text = ("SCORE: "+finalScore);
	}
}