using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private WeaponInventory _weaponInventory;
    [SerializeField] private Projectile _projectile;
    [SerializeField] private Transform _spawnPosition;

    public void Shoot()
    {
        if (_weaponInventory.CurrentAmmo.CurrentAmmo > 0)
        {
            if (_weaponInventory.CurrentWeapon.IsMulti)
            {
                Instantiate(_projectile, _spawnPosition.position, Quaternion.identity);
                Instantiate(_projectile, _spawnPosition.position + new Vector3(0.5f, 0.2f, 0), Quaternion.identity);
                Instantiate(_projectile, _spawnPosition.position+ new Vector3(-0.5f, 0.3f, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(_projectile, _spawnPosition.position, Quaternion.identity);
            }
        }
        _weaponInventory.CurrentAmmo.AmmoUpdate();
        _weaponInventory.TextUpdate();
    }
}