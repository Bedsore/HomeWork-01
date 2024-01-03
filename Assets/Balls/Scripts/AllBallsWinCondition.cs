using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllBallsWinCondition : IWinCondition
{
    private List<Ball> ballsForWin;

    public List<Ball> GetWinnerBalls(List<Ball> ballsOnScene)
    {
        ballsForWin = ballsOnScene;
        Debug.Log("You should clap ALL BALLS");
        return ballsForWin;
    }
}
