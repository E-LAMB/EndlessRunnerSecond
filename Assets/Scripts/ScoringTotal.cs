using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringTotal : MonoBehaviour
{

    public int score = 0;

    public GameObject scoreText;

    public void ScoringAdding()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + score;
        score += 1;
        Debug.Log("Point earned");
    }

}
