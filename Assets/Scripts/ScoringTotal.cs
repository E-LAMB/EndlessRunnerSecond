using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringTotal : MonoBehaviour
{

    public static ScoringTotal instance;

    public static int score = 0;
    public int points;

    public Text scoreText;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreText.ToString() + " POINTS";
    }

    public void gains_points()
    {
        score += 1;
        scoreText.text = scoreText.ToString() + " POINTS";
    }

    private void Update()
    {
        points = score;
    }

}
