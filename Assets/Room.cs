﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject virtualCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Enter!");
        if(other.CompareTag("Player")) {
            
            virtualCam.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("Exit!");
        if(other.CompareTag("Player")) {

            virtualCam.SetActive(false);
        }
    }
}
