﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public Button buttonUp;
    public Button buttonDown;
    private Vector2 newPos;
    public float Yvalue;
    public float speed;
    public float maxHeight;
    public float minHeight;

   
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, newPos, speed * Time.deltaTime);
        
            buttonUp.onClick.RemoveAllListeners();
            buttonUp.onClick.AddListener(() => PlayerUp());
        
        
            Debug.Log("Y value is " + transform.position.y + " - and min is " + minHeight);
            buttonDown.onClick.RemoveAllListeners();
            buttonDown.onClick.AddListener(() => PlayerDown());
        
        //Debug.Log("Y value is " + Yvalue);
    }

    void PlayerUp()
    {
        //Debug.Log("2Y value is " + transform.position.y + " - and max is " + maxHeight);
        if (transform.position.y < maxHeight)
        {
            newPos = new Vector2(transform.position.x, transform.position.y + Yvalue);
        }
        
    }

    void PlayerDown()
    {
        if (transform.position.y > minHeight)
        {
            newPos = new Vector2(transform.position.x, transform.position.y - Yvalue);
        }
    }
}
