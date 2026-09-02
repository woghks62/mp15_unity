using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private Transform _target;

    private void Update()
    {
        Vector3 movement = GetMovement();
        Move(movement);
        //MoveToTarget();
        CubeRotate(movement);
    }

    private void CubeRotate(Vector3 movement)
    {
        if (movement == Vector3.zero)
        {
            return;
        }

        Quaternion look = Quaternion.LookRotation(movement);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            look,
            _rotateSpeed * Time.deltaTime
            );
    }

    //private void CubeRotate()
    //{
    //    //if (Input.GetKey(KeyCode.R))
    //    //{
    //    //    transform.Rotate(Vector3.up, _rotateSpeed*Time.deltaTime);
    //    //}
    //}


    void Move(Vector3 movement)
    {
        if(movement == Vector3.zero)
        {
            return;
        }

        //transform.position += movement * _moveSpeed * Time.deltaTime;
        //transform.Translate(movement * _moveSpeed * Time.deltaTime);


        transform.Translate(
            Vector3.forward * _moveSpeed * Time.deltaTime
            );
    }

    Vector3 GetMovement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(x, 0, z);
        return movement.normalized;
        //movement.Normalize();
        //movement.normalized;
    }




    private void MoveToTarget()
    {
        // 멀리 있는적은 더 빠르게 오는법
        // 0에서 1까지에서 05 0.75 0.875 이런식으로 절반씩??
        transform.position = Vector3.Lerp(
            transform.position,
            _target.position,
            _moveSpeed * Time.deltaTime
         );

        //transform.position = Vector3.MoveTowards(
        //    transform.position, 
        //    _target.position, 
        //    _moveSpeed * Time.deltaTime);
    }
}
