using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private Camera _cam;

    // 어떤 것이 선택되어 있는지
    [SerializeField] private UnitMovement _target;

    private void Start()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        RayShot();
        MoveTarget();//
    }

    private void MoveTarget()
    {
        if (!Input.GetMouseButtonDown(1) || _target == null) return;

        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (!hit.transform.CompareTag("Ground")) return;

            _target.SetDestination(hit.point);  // 레이가 부딪힌 지점
        }
    }
    
    private void RayShot()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray,out hit))
        {
            if (hit.transform.CompareTag("Ground"))
            {
                _target = null;
                return;
            }

            Debug.Log($"{hit.transform.name} 선택");
            _target = hit.transform.GetComponent<UnitMovement>();
        }
        else
        {
            _target = null;
            return;
        }
    }
}
