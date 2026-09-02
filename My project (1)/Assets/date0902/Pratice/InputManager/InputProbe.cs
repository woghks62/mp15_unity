using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputProbe : MonoBehaviour
{

    // 3. 스페이스로 큐브 보이기·숨기기

    private Renderer _renderer;

    private void Awake()
    {
        CacheComponents();
    }

    private void Update()
    {
        ReadToggleKey();
    }

    private void CacheComponents()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void ReadToggleKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _renderer.enabled = !_renderer.enabled;
            Debug.Log($"InputProbe: 보이기 상태는 {_renderer.enabled}입니다.");
        }
    }



    /*
    // 2. 키 세 함수의 차이 보기
    private void Update()
    {
        ReadKeys();
    }

    private void ReadKeys()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("InputProbe: GetKeyDown");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("InputProbe: GetKey");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("InputProbe: GetKeyUp");
        }
    }
    */
}
