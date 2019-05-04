using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public Button buttonUp;
    public Button buttonDown;
    private Vector2 newPos;
    public float Yvalue;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    private bool press = false;
    //prevents bubbles and sound looping
    //while the load delay happens
    private bool animOnce = true;

    public Text timr;
    public Text healthiness;

    public GameObject bubbles;
    public GameObject sound;

   
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        int now = (int)Time.time;
        timr.text = now.ToString();
        healthiness.text = "HP: " + health.ToString();
        if (health == 0 && animOnce)
        {
            SpriteRenderer rend = this.gameObject.GetComponent<SpriteRenderer>();
            rend.enabled = false;
            Instantiate(bubbles, transform.position, Quaternion.identity);
            Instantiate(sound, transform.position, Quaternion.identity);
            //} else if (health <= 0)
            //{
            //restart
            //need to make a game over scene
            animOnce = false;
            StartCoroutine(ExecuteAfterTime(0.5f));
        }
        
        //this is just to stop the player from lurching forward
        if (press) {
            transform.position = Vector2.MoveTowards(transform.position, newPos, speed * Time.deltaTime);
        }
        
        //ignores if statements here - don't know why
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
            Instantiate(bubbles, transform.position, Quaternion.identity);
            newPos = new Vector2(transform.position.x, transform.position.y + Yvalue);
            Instantiate(sound, transform.position, Quaternion.identity);
            press = true;
        }
        
    }

    void PlayerDown()
    {
        if (transform.position.y > minHeight)
        {
            Instantiate(bubbles, transform.position, Quaternion.identity);
            newPos = new Vector2(transform.position.x, transform.position.y - Yvalue);
            Instantiate(sound, transform.position, Quaternion.identity);
            press = true;
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("GameOver");
    }
}
