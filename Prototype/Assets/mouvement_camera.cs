﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement_camera : MonoBehaviour {
    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        //offset = transform.position = player.transform.position;
        offset = new Vector3(0.0f, 5.0f, 15.0f);
    }
	// Update is called once per frame
	void Update () {
       transform.position = player.transform.position + offset;

    }
}
