﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Gerard Lamoureux
 * Challenge 1
 * Manages the score of the game
 */

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
            textbox.text = "Score: " + score;
        if(score >= 5)
        {
            won = true;
            gameOver = true;
        }
        if(gameOver)
        {
            if(won)
            {
                textbox.text = "You Win!\nPress R to Restart!";
            }
            else
            {
                textbox.text = "You Lose!\nPress R to Restart!";
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
