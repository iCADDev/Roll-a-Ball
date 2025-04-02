using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCollectable : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private void OnTriggerEnter(Collider other) {
        if (other.transform.CompareTag("Collect")) 
    {
        Destroy(other.gameObject);
        score++;
        scoreText.text = "Score :" + score;
    }
    }
}