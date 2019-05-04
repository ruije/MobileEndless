using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public int damage = 1;
    public float speed;

    public GameObject bubbles;
    public GameObject sound;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Instantiate(sound, transform.position, Quaternion.identity);
            Instantiate(bubbles, transform.position, Quaternion.identity);
            collision.GetComponent<PlayerController>().health -= damage;
            Destroy(gameObject);
        }
    }
}
