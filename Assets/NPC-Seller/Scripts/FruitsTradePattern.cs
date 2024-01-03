using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsTradePattern : ITrader
{
    public string GetName() => "Fruits";

    public void Trade()
    {
        Debug.Log("Taker some Fruits Friend");
    }
}
