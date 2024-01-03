using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCounter : MonoBehaviour
{
    private IWinCondition _winCondition;
    public List<Ball> _ballsOnScene;
    private List<Ball> _ballsForWin;

    private void Start()
    {
        _winCondition = new AllBallsWinCondition();
        SetCondition(_winCondition);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _winCondition = new RedBallWinCondition();
            SetCondition(_winCondition);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _winCondition = new AllBallsWinCondition();
            SetCondition(_winCondition);
        }
    }

    public void ClapBall(Ball ball)
    {
        for (int i = _ballsForWin.Count - 1; i >= 0; i--)
        {
            if (_ballsForWin[i] == ball)
            {
                _ballsForWin.Remove(_ballsForWin[i]);
                Destroy(ball.gameObject);
            }
        }

        if (_ballsForWin.Count == 0)
        {
            Debug.Log("You Win Bro");
        }
    }

    private void SetCondition(IWinCondition winCondition)
    {
        _ballsForWin = winCondition.GetWinnerBalls(_ballsOnScene);
    }
}