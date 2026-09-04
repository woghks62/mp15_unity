using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{gameObject.name} : 트리거 안에 {other.gameObject.name} 들어옴");

        IDamageable d = other.gameObject.GetComponent<CubeController>();

        if( d != null)
        {
            d.TakeDamage(11);
        }
        

        //if (other.gameObject.CompareTag("Player"))
        //{
        //    //Debug.Log("플레이어가 범위 내로 들어왔음. 문 열기");
        //    //CubeController c = other.gameObject.GetComponent<CubeController>();
        //    //c.TakeDamage(11);

        //    IDamageable d = other.gameObject.GetComponent<CubeController>();
        //    d.TakeDamage(11);
        //}
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"{gameObject.name} : 트리거 안에 {other.gameObject.name} 있음");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"{gameObject.name} : 트리거 밖으로 {other.gameObject.name} 나감");
    }
}
