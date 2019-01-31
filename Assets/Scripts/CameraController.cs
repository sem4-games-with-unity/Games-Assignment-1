﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject sphere;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(sphere.transform.position.x,transform.position.y,sphere.transform.position.z - 10);
        transform.LookAt(sphere.transform.position);
    }
}
