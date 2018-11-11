using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {

    int score = 0;
    int health;

	// Use this for initialization
	void Start () {
        SetUpSingleton();
	}

    private void SetUpSingleton()
    {
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        if(numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            health = FindObjectOfType<Player>().GetHealth();
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int healthValue)
    {
        health = healthValue;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
