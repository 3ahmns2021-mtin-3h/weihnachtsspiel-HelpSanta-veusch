﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enemy");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Hallo Enemy1" + collision.name); 
    }
    // Update is called once per frame
    void Update()   
    {
        
    }
}
