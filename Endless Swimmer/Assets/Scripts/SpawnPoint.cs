using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {
        Instantiate(obj, transform.position, Quaternion.identity);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
