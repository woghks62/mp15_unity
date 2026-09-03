using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    [SerializeField] private float _degreePerSecond = 60f;
    private const string AXIS_HORIZONTAL = "Horizontal";
    private const string AXIS_VERTICAL = "Vertical";

    [SerializeField] private float _meterPerSecond = 3f;

    public GameObject _target;

    

    private void MoveByKey()
    {
        float horizontal = Input.GetAxisRaw(AXIS_HORIZONTAL);
        float vertical = Input.GetAxisRaw(AXIS_VERTICAL);
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        _target.transform.position += direction.normalized * _meterPerSecond * Time.deltaTime;
         
    }

    private void Update()
    {
        //Vector3 movement = GetMovement();
        //Move(movement);
        //CubeRotate(movement);

        Spin();
        AddSpeed();
        if (_degreePerSecond >= 700)
        {
            MoveByKey();
            Fly();
        }
        
    }

    private void Spin()
    {
        transform.Rotate(Vector3.up * _degreePerSecond * Time.deltaTime);
    }

    void AddSpeed()
    {
        if(_degreePerSecond < 1000)
        {
            _degreePerSecond += 1;
        }
    }

    void Fly()
    {
        if (_target.transform.position.y <= 5)
        {
            _target.transform.position += Vector3.up * 1 * Time.deltaTime;
        }
    }

    //void Move()
    //{
    //    if (movement == Vector3.zero)
    //    {
    //        return;
    //    }

    //    transform.Translate(
    //        direction.normalized * _moveSpeed * Time.deltaTime
    //        );
    //}

    //void GetMovement()
    //{
    //    float horizontal = Input.GetAxisRaw(AXIS_HORIZONTAL);
    //    float vertical = Input.GetAxisRaw(AXIS_VERTICAL);

    //    Vector3 direction = new Vector3(horizontal, 0f, vertical);
    //    return direction.normalized;
    //}

    //private void CubeRotate(Vector3 movement)
    //{
    //    if (movement == Vector3.zero)
    //    {
    //        return;
    //    }

    //    Quaternion look = Quaternion.LookRotation(movement);

    //    transform.rotation = Quaternion.Slerp(
    //        _target.transform.rotation,
    //        look,
    //        _rotateSpeed * Time.deltaTime
    //        );
    //}
}
