using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tempVel = myRigidbody.velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            tempVel.y = 5f;
            
        }
        myRigidbody.velocity = tempVel;
    }
}
