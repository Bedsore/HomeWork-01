using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;

public class Ammo
{
    private bool _isAmmoEndless;
    private int _ammoStart;
    private int _ammoCount;

    public Ammo(bool isAmmoEndless, int ammoStart)
    {
        _isAmmoEndless = isAmmoEndless;
        _ammoStart = ammoStart;
        _ammoCount = _ammoStart;
    }

    public Ammo(bool isAmmoEndless)
    {
        _isAmmoEndless = isAmmoEndless;
        _ammoStart = 9999;
        _ammoCount = _ammoStart;
    }
    
    public int AmmoStart => _ammoStart;
    public int CurrentAmmo => _ammoCount;
    
    public void AmmoUpdate()
    {
        if (_isAmmoEndless && _ammoCount > 0)
        {
            _ammoCount -= 1;
        }
    }

    public void Reload()
    {
        if (_isAmmoEndless)
        {
            _ammoCount += _ammoStart;
        }
    }
}
