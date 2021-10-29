using TMPro;
using UnityEngine;

public class WeaponUI : MonoBehaviour
{
    [SerializeField] private Ammo _ammo;

    [SerializeField] private TMP_Text _numberLaser;
    [SerializeField] private TMP_Text _timeReloadLaser;

    private void Update()
    {
        _numberLaser.text = $"Laser: {_ammo.CurrentAmmo}";

        _timeReloadLaser.text = $"ReloadLaser: {_ammo.TimeReloadAmmoView}";
    }
}
