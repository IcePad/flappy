﻿using UnityEngine;
using System.Collections;

public class RepeatingbG : MonoBehaviour {
    public float speed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 offset = new Vector2( Time.time* speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
