using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GunController : MonoBehaviour
{
    [SerializeField] private GameObject _launch, _bulletPrefab;
    private bool _okayToShoot = false;
    private bool _shootingPaused = false;
    private ControllerInput _inputData;

    void Start()
    {
       _inputData = GetComponent<ControllerInput>(); 
    }

    void Update()
    {
       if( _okayToShoot)
        {
            if( !_shootingPaused )
            {
                if(_inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool _aButtonPressed))
                {
                    if(_aButtonPressed)
                    {
                        _shootingPaused = true;
                        Fire();
                        StartCoroutine(Pause());
                    }
                }
            }
        } 
    }

    private void Fire()
    {
        GameObject bullet = Instantiate(_bulletPrefab) as GameObject;
        bullet.GetComponent<Bullet>().SetPowerUp(GetComponent<PowerUp>());
        bullet.SetActive(true);
        bullet.transform.position = _launch.transform.position;
        bullet.transform.rotation = _launch.transform.rotation;

        bullet.GetComponent<Rigidbody>().AddForce(_launch.transform.forward * 50f, ForceMode.Impulse);
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(0.5f);
        _shootingPaused = false;
    }

    public void PickedUpWeaponTrigger()
    {
        _okayToShoot = true;
    }

    public void DroppedWeaponTrigger()
    {
        _okayToShoot = false;
    }
}
