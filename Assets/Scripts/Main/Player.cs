using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public Rigidbody2D rb;
    public float speed;
    public float air;
    public float jump;
    public Animator anim;


	void Update ()
	{

	}

    public void Ollie()
    {
        rb.AddForce(new Vector2(0f, jump));
    }

    public void Flip()
    {

    }

    public void Grab()
    {

    }
}