using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorTradePattern : ITrader
{
    public string GetName() => "Armor";

    public void Trade()
    {
        Debug.Log("Taker some Armor bro");
    }
}
