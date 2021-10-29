using System;
using System.Collections;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] private int _maxAmmo;
    private int _currentAmmo;
    private const byte _noAmmo = 0;

    [SerializeField] private float _timeReloadAmmo;
    [SerializeField] private float _speedCountdownReloadAmmo;
    private float _currentTimeReloadAmmo;
    private const byte _limitTimeReloadAmmo = 0;

    private bool _isReloading = false;

    public int NoAmmo => _noAmmo;
    public int CurrentAmmo => _currentAmmo;
    public float TimeReloadAmmoView => _currentTimeReloadAmmo;

    private void Start()
    {
        if (_maxAmmo <= _noAmmo)
            throw new ArgumentOutOfRangeException(nameof(_maxAmmo));

        SetCurrentAmmo();
        SetCurrentCountdownTimeView();
    }

    private void Update()
    {
        ConditionsReloadingAmmo();
    }

    public void SpentCartridg()
    {
        _currentAmmo--;
    }

    private void ConditionsReloadingAmmo()
    {
        if (_currentAmmo > _maxAmmo)
            throw new ArgumentOutOfRangeException(nameof(_currentAmmo));

        if (_isReloading)
            return;

        ReloadAmmo();
        NegativReloadAmmo();
    }

    private void ReloadAmmo()
    {
        if (_currentAmmo == _noAmmo)
            StartCoroutine(AutoReloadAmmo());
    }

    private void NegativReloadAmmo()
    {
        if (_currentAmmo < _noAmmo)
        {
            _currentAmmo = _noAmmo;

            StartCoroutine(AutoReloadAmmo());
        }
    }

    private IEnumerator AutoReloadAmmo()
    {
        _isReloading = true;

        while (_currentTimeReloadAmmo > _limitTimeReloadAmmo)
        {
            yield return new WaitForSeconds(_speedCountdownReloadAmmo);

            _currentTimeReloadAmmo--;
        }

        SetCurrentAmmo();
        SetCurrentCountdownTimeView();

        _isReloading = false;
    }

    private void SetCurrentAmmo()
    {
        _currentAmmo = _maxAmmo;
    }

    private void SetCurrentCountdownTimeView()
    {
        _currentTimeReloadAmmo = _timeReloadAmmo;
    }
}
