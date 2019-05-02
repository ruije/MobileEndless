using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour {

    public GameObject[] obstacles;
    private float timeRemaining;
    public float spawnDelta;
    public float increaseDifficulty;
    public float minDelta = 0.65f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timeRemaining <= 0)
        {
            int rand = Random.Range(0,obstacles.Length);
            //spawn with no rotation
            Instantiate(obstacles[rand], transform.position, Quaternion.identity);
            timeRemaining = spawnDelta;
            if (spawnDelta >= minDelta) {
                spawnDelta -= increaseDifficulty;
            }
        }
        else
        {
            timeRemaining -= Time.deltaTime;
        }
	}
}
