using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _weaponText;
    [SerializeField] private TextMeshProUGUI _ammoText;
    
    private Weapon _currentWeapon;
    private Ammo _currentAmmo;

    private Weapon _pistol;
    private Weapon _machinegun;
    private Weapon _shotgun;

    private Ammo _pistolAmmo;
    private Ammo _shotGunAmmo;
    private Ammo _machineGunAmmo;

    private void Awake()
    {
        Init();
        _currentWeapon = _pistol;
        _currentAmmo = _pistolAmmo;
        TextUpdate();
    }
    
    private void Init()
    {
        _pistolAmmo = new Ammo(true, 12);
        _machineGunAmmo = new Ammo(false);
        _shotGunAmmo = new Ammo(true, 5);

        _pistol = new Weapon(_pistolAmmo, "Pistol", false);
        _machinegun = new Weapon(_machineGunAmmo, "Machine gun", false);
        _shotgun = new Weapon(_shotGunAmmo, "Shotgun", true);
    }

    public void SwitchWeapon(int number)
    {
        switch (number)
        {
            case 1:
                _currentWeapon = _pistol;
                _currentAmmo = _pistolAmmo;
                break;
            case 2:
                _currentWeapon = _machinegun;
                _currentAmmo = _machineGunAmmo;
                break;
            case 3:
                _currentWeapon = _shotgun;
                _currentAmmo = _shotGunAmmo;
                break;
        }
        TextUpdate();
    }
    public void TextUpdate()
    {
        _weaponText.text = _currentWeapon.Name;
        _ammoText.text = _currentAmmo.CurrentAmmo.ToString();
    }

    public void Reload()
    {
        _currentAmmo.Reload();
        TextUpdate();
    }

    public Weapon CurrentWeapon => _currentWeapon;
    public Ammo CurrentAmmo => _currentAmmo;

}