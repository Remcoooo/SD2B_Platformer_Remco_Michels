using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreSystem : MonoBehaviour
{
    public static int score;
    Text scoreText;
    private void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    private void Update()
    {
        scoreText.text = "Score: " + score;
    }
}