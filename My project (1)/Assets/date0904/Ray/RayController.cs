using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour
{
    
    private void Update()
    {
        RayShot();
    }

    private void RayShot()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        Ray ray = new Ray(transform.position, transform.forward);


        // 실제로 충돌된 애의 정보를 가지고 있음 : hit
        //RaycastHit hit;
        // 이건 지금 거리가 1000이든 10000이든 다 감지함
        //if(Physics.Raycast(ray, out hit))       // Raycast는 반환타입이 bool타입
        //{
        //    Debug.Log(hit.transform.name);
        //}
        //if (Physics.Raycast(ray, out hit, 1f))       // 매개변수가 3개면 최대거리를 지정할 수 있다
        //{
        //    Debug.Log(hit.transform.name);
        //}

        RaycastHit[] hits = Physics.RaycastAll(ray, 10f);

        if (hits.Length > 0)
        {
            foreach (RaycastHit hit in hits)
            {
                Debug.Log(hit.transform.name);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * 10);
    }
}
