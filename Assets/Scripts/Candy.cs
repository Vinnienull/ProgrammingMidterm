using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candy : MonoBehaviour
{

    [SerializeField] int value;

    [SerializeField] GameObject Player;
    [SerializeField] GameObject candyKiller;

    [SerializeField] Text scoreText;

    private void Start()
    {
        Player = GameObject.Find("Monster");
        candyKiller = GameObject.Find("Candy Killbox");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == Player)
        {
            Debug.Log("Player hit candy worth " + value + " points!");
            Destroy(gameObject);
            PointsManager.score += value;
            Debug.Log(PointsManager.score);
            PointsManager.candiesLeft -= 1;
            Debug.Log(PointsManager.candiesLeft + " candies left!");
            scoreText.text = "Score = " + PointsManager.score;
        }
        else if (col.gameObject == candyKiller)
        {
            Debug.Log("Player missed candy");
            Destroy(gameObject);
            PointsManager.candiesLeft -= 1;
            Debug.Log(PointsManager.candiesLeft + " candies left!");
        }
    }
}
