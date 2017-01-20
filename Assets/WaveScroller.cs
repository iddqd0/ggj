using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScroller : MonoBehaviour {


    public float speed = 1.0f;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        // shift backwards n pixels every pace time for duration
        
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * speed, 0);
    }
}
