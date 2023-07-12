using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallResetBehaviour : MonoBehaviour
{
    /// <summary>
    /// When a player scores the ball will be reset
    /// </summary>
    /// <param name="playerIndex"></param> The index of the player that scores, not relevant
    public void OnScore(int playerIndex)
    {
        transform.position = new Vector3(0, 0, 0);
    }
}
