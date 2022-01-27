using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Gerard Lamoureux
 * Challenge 1
 * Checks if player is out of bounds
 */

public class PlayerOutOfBoundsCheck : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 80 || transform.position.y < -51)
            ScoreManager.gameOver = true;
    }
}
