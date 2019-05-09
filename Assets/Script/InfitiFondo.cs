using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfitiFondo : MonoBehaviour {

    private float speed = 1.5f;
    Vector2 Fondopost;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void MoveFondo()
    {
        Fondopost = new Vector2(Time.time * speed, 0);

        GetComponent<Renderer>().material.mainTextureOffset = Fondopost;
    }
}
