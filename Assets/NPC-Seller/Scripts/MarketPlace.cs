using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class MarketPlace : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private static readonly int NoTrade = Animator.StringToHash("NoTrade");
    private static readonly int Armor = Animator.StringToHash("Armor");
    private static readonly int Fruit = Animator.StringToHash("Fruit");

    private Trader _trader;

    private void Start()
    {
        _trader = new Trader(new NoTradePattern());
    }

    private void Update()
    {
        Buy();
        SetTraderBehaivour();
    }

    public void SetTraderBehaivour()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetBool(NoTrade, true);
            _animator.SetBool(Armor, false);
            _animator.SetBool(Fruit, false);
            _trader.SetBehaviour(new NoTradePattern());
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _animator.SetBool(NoTrade, false);
            _animator.SetBool(Armor, true);
            _animator.SetBool(Fruit, false);
            _trader.SetBehaviour(new FruitsTradePattern());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _animator.SetBool(NoTrade, false);
            _animator.SetBool(Armor, false);
            _animator.SetBool(Fruit, true);
            _trader.SetBehaviour(new ArmorTradePattern());
        }
    }

    public void Buy()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            _trader.Trade();
        }
    }
}