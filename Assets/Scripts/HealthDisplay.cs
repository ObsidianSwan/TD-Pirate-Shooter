using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {

    Text healthText;
    GameSession gameSession;

    // Use this for initialization
    void Start () {
        healthText = GetComponent<Text>();
        gameSession = FindObjectOfType<GameSession>();
    }
	
	// Update is called once per frame
	void Update () {
        healthText.text = gameSession.GetHealth().ToString();
    }
}
