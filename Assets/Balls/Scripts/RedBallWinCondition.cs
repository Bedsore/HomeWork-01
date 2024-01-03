using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallWinCondition : IWinCondition
{
    private List<Ball> ballsForWin = new List<Ball>();
    
    public List<Ball> GetWinnerBalls(List<Ball> ballsOnScene)
    {
        CheckForColor(ballsOnScene);
        Debug.Log("You should clap just RED BALLS");
        return ballsForWin;
    }
    
    public void CheckForColor (List<Ball> ballsOnScene)
    {
        foreach (var ballOnScene in ballsOnScene)
        {
            if (ballOnScene is RedBall)
            {
                ballsForWin.Add(ballOnScene);
            }
        }
    }
}