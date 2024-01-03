using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunslinger : MonoBehaviour
{
    [SerializeField] private WeaponInventory _weaponInventory;
    [SerializeField] private Shooter _shooter;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) _weaponInventory.SwitchWeapon(1);
        if (Input.GetKeyDown(KeyCode.Alpha2)) _weaponInventory.SwitchWeapon(2);
        if (Input.GetKeyDown(KeyCode.Alpha3)) _weaponInventory.SwitchWeapon(3);

        if (Input.GetMouseButtonDown(0)) _shooter.Shoot();
        if (Input.GetKeyDown(KeyCode.R)) _weaponInventory.Reload();
    }
}
