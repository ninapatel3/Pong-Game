using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private int _player1Score;
    private int _player2Score;

    [SerializeField] private Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        _player1Score = 0;
        _player2Score = 0;
        scoreText.text = _player1Score + " - " + _player2Score;

    }

    public void OnScore(int player)
    {
        if (player == 1)
        {
            _player1Score += 1;
        }
        else if (player == 2)
        {
            _player2Score += 1;
        }

        scoreText.text = _player1Score + " - " + _player2Score;



    }
}
