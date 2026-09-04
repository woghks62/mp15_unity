using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour, IMoveable
{
    // 1. 목적지를 받기
    // 2. 목적지가 정해졌으면 그쪽으로 이동하기
    // 3. 목적지에 도착하면 목적지 해제하기

    [SerializeField] private float _movespeed = 10;


    private Vector3 _destination;
    private bool _isMoving;


    //[SerializeField] private float _moveSpeed;

    

    private void Update()
    {
        Move(_movespeed);
    }

    public void Move(float _movespeed)
    {
        if (_isMoving == false) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            _destination,
            _movespeed * Time.deltaTime
            );

        if(Vector3.Distance(transform.position, _destination) <= 1f)
        {
            _isMoving = false;
            
        }
    }


    public void SetDestination(Vector3 destination)
    {
        _destination = destination;
        _isMoving = true;
    }
}
