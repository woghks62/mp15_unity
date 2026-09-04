using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Collision (충돌)
    // - Enter : 충돌 시작했을 때
    // - Stay : 충돌이 유지되고 있을 때
    // - Exit : 충돌이 종료됐을 때

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"{gameObject.name} : {collision.gameObject.name}랑 충돌했다");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"{gameObject.name} : {collision.gameObject.name}랑 붙어있음");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"{gameObject.name} : {collision.gameObject.name}랑 멀어짐");
    }


    // Trigger (스위치)



    //// Rigidbody
    //private void Update()
    //{
    //    Foo();
    //}

    //void Foo()
    //{
    //    if (!Input.GetKey(KeyCode.Space)) return;


    //    // AddForce();
    //    //if (!Input.GetKeyDown(KeyCode.Space)) return;
    //    //_rigidbody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);

    //    // velocity;
    //    // if (!Input.GetKey(KeyCode.Space)) return;
    //    //_rigidbody.velocity = new Vector3(0, 0, 5);
    //    _rigidbody.angularVelocity = new Vector3(0, 0, 5);

    //}
}
