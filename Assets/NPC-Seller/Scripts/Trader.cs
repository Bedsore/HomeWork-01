using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trader
{
    private ITrader _traderBehaviour;

    public Trader(ITrader traderBehaviour)
    {
        _traderBehaviour = traderBehaviour;
    }

    public void SetBehaviour(ITrader tradeBehaviour)
    {
        _traderBehaviour = tradeBehaviour;
        Debug.Log(_traderBehaviour.GetName());
    }

    public void Trade()
    {
        _traderBehaviour.Trade();
    }
}