using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_Controller : MonoBehaviour {
    public  float moveSpeed;
    public Animator myAnime;

	// Use this for initialization
	void Start () 
    {
        myAnime = this.GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetAxisRaw("Horizontal")<0)
        //if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Set animation to go left
            myAnime.SetInteger("DIR", 2);
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }
         else if(Input.GetAxisRaw("Horizontal")>0)
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Set animation to go right
            myAnime.SetInteger("DIR", 0);
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetAxisRaw("Vertical")<0)

        {
            // Set animation to go down
            myAnime.SetInteger("DIR", 3);
        }
       else if (Input.GetAxisRaw("Vertical")>0)
        {
            // Set animation to go up
            myAnime.SetInteger("DIR", 1);
        }

	}
}
