using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTradePattern : ITrader
{
    public string Message => "No commerce today Bro";
    
    public string GetName() => Message;

        public void Trade()
    {
        GetName();
    }
}