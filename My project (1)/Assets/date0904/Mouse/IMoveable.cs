using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveable 
{
    //bool IsMoving { get; set; }
    //float MoveSpeed {  get; set; }      // 얘는 고정속도가 필요한애
                                        // MoveSpeed가 필요한애 두명이 있으면
                                        // 굳이 두 개 스크립트에 다 값을 넣어야함
    void Move(float MoveSpeed);


    //void SetDestination(Vector3 destination);
    //Vector3 Destination { get; set; }
}
