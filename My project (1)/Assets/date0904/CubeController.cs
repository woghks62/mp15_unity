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

    
    // Rigidbody
    private void Update()
    {
        Foo();
    }

    void Foo()
    {
        if (!Input.GetKey(KeyCode.Space)) return;


        // AddForce();
        //if (!Input.GetKeyDown(KeyCode.Space)) return;
        //_rigidbody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);

        // velocity;
        // if (!Input.GetKey(KeyCode.Space)) return;
        //_rigidbody.velocity = new Vector3(0, 0, 5);
        _rigidbody.angularVelocity = new Vector3(0, 0, 5);
        
    }
}
