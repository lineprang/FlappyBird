using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D myRigidbody;

    private void Awake()
    {
      myRigidbody= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempPosition = transform.localPosition;
        Vector2 tempVelocity = myRigidbody.velocity;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tempPosition.y += 5f;
            //tempPosition.x += 3f;
            tempVelocity.y += 5f;
        }
    transform.localPosition = tempPosition;
        myRigidbody.velocity = tempVelocity;
    }
}

