using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private Ammo _ammo;
    private string _name;
    private bool _isMultiShot;
    private int _currentAmmo;
    
    public Weapon(Ammo ammo, string name, bool isMultiShot)
    {
        _ammo = ammo;
        _name = name;
        _isMultiShot = isMultiShot; 
        _currentAmmo = _ammo.AmmoStart;
    }

    public string Name => _name;
    public bool IsMulti => _isMultiShot;
    public Ammo Ammo => _ammo;
    public int CurrrentAmmo => _currentAmmo;

}