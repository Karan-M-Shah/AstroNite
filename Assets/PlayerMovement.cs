using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class PlayerMovement : MonoBehaviour {
    Rigidbody2D rb2d;
    public float walkspeed = 10f;
    public float Jumpforce = 6f;
    public bool InAir = false;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Walk();
            Debug.Log("D is being pressed");
        }
        if (Input.GetKey(KeyCode.A))
        {
            WalkBack();
            Debug.Log("A is being pressed");
        }
        if (Input.GetKeyDown(KeyCode.W)&& InAir == false)
        {
            InAir = true;
            Jump();
            InAir = false;
            Debug.Log("W is being pressed");
            
        }
    }

    public void Walk()
    {
        transform.Translate(walkspeed * Time.deltaTime, 0, 0);
    }
    public void WalkBack()
    {
        transform.Translate(-walkspeed * Time.deltaTime, 0, 0);
    }
    
    public void Jump()
    {
        rb2d.AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
    }
}

