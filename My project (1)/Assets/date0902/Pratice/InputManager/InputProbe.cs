using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputProbe : MonoBehaviour
{
    // 8. 마우스가 움직인 양 읽기
    private const string AXIS_MOUSE_X = "Mouse X";
    private const string AXIS_MOUSE_Y = "Mouse Y";

    private void Update()
    {
        ReadToggleKey();
        ReadAxes();
        ReadMouseButton();
        ReadMouseDelta();
    }


    private void ReadMouseDelta()
    {
        float mouseX = Input.GetAxis(AXIS_MOUSE_X);
        float mouseY = Input.GetAxis(AXIS_MOUSE_Y);
        Debug.Log($"InputProbe: 마우스가 가로 {mouseX}, 세로 {mouseY}만큼 움직였습니다.");
    }


    // 7. 마우스 버튼과 좌표 읽기
    private const int MOUSE_BUTTON_LEFT = 0;

    private void ReadMouseButton()
    {
        if (Input.GetMouseButtonDown(MOUSE_BUTTON_LEFT))
        {
            // 여기에 좌표를 찍는 한 줄을 씁니다.  
            Debug.Log($"Input.mousePosition: 값은 {Input.mousePosition}입니다.");
        }
    }

    //private void Update()
    //{
    //    ReadToggleKey();
    //    ReadAxes();
    //    ReadMouseButton();
    //}

    // 6. 축 값으로 누적하기
    [SerializeField] private float _amountPerSecond = 1f;

    private float _total;

    private void ReadAxes()
    {
        float raw = Input.GetAxisRaw(AXIS_HORIZONTAL);
        _total += raw * _amountPerSecond * Time.deltaTime;
        Debug.Log($"InputProbe: 누적값은 {_total}입니다.");
    }


    // 5. 두 축 함수의 값 나란히 찍기
    private const string AXIS_HORIZONTAL = "Horizontal";

    //private void Update()
    //{
    //    ReadToggleKey();
    //    ReadAxes();
    //}

    //private void ReadAxes()
    //{
    //    float smoothed = Input.GetAxis(AXIS_HORIZONTAL);
    //    float raw = Input.GetAxisRaw(AXIS_HORIZONTAL);
    //    Debug.Log($"InputProbe: GetAxis는 {smoothed}, GetAxisRaw는 {raw}입니다.");
    //}


    // 3. 스페이스로 큐브 보이기·숨기기

    private Renderer _renderer;

    private void Awake()
    {
        CacheComponents();
    }

    //private void Update()
    //{
    //    ReadToggleKey();
    //}

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
