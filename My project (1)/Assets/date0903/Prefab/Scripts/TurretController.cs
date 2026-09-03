using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _muzzleTransform;

    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _detectionRange;

    // 총알 소환
    // 총구 위치에

    // 격발음
    float time = 0;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, _playerTransform.position);

        if (distance <= _detectionRange)
        {
            LookAtPlayer();
            SpawnBullet();
        }
        else
        {
            RotateTurret();
        }
    }

    // 플레이어가 특정 거리 밖에 있을땐 빙글빙글 돈다.
    private void RotateTurret()
    {
        transform.Rotate(Vector3.up, _rotateSpeed * Time.deltaTime);
    }


    // 일정 거리 내에 있을 때는 플레이어 응시한다.
    private void LookAtPlayer()
    {
       transform.LookAt(_playerTransform);
    }

    private void SpawnBullet()
    {
        
        time += Time.deltaTime;
        // 쿨타임
        if(time >= 1)
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            bullet.transform.position = _muzzleTransform.position;
            bullet.transform.rotation = _muzzleTransform.rotation;
            time = 0;
        }


        //GameObject bullet = Instantiate(_bulletPrefab);
        //bullet.transform.position = _muzzleTransform.position;
        //bullet.transform.rotation = _muzzleTransform.rotation;
    }
}
