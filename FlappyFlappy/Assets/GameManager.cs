using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
    }

    public Text scoreText;
    private void Update()
    {
        scoreText.text = "Score: " + collisionCount;
    }

}

