using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public int collisionCount = 0;
    public TextMeshProUGUI scoreText;

    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
    }

    private void Update()
    {
        scoreText.text = "Score: " + collisionCount;
    }

}