using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWinCondition
{
    public List<Ball> GetWinnerBalls(List<Ball> ballsOnScene);
}