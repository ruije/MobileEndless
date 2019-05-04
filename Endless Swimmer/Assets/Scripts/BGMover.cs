using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMover : MonoBehaviour {

    public float speed;

    public float startX;
    public float finishX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= finishX)
        {
            transform.position = new Vector2(startX, transform.position.y);
        }
	}
}
