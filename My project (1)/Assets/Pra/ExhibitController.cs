using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitController : MonoBehaviour
{
    [SerializeField] private Renderer _baseRenderer;
    [SerializeField] private float _turnPerFrame = 0.5f;
    [SerializeField] private float _startAngle = 30;

    private Renderer _selfRenderer;

    private Renderer _spotRenderer;

    private float _angle;



    private void Awake()
    {
        CacheComponents();
        InitAngle();
    }

    private void OnEnable()
    {
        ActivateVisual();
    }

    // Start is called before the first frame update
    void Start()
    {
        BindSpot();
    }

    // Update is called once per frame
    void Update()
    {
        TurnExhibit();
    }

    private void OnDisable()
    {
        DeactivateVisual();
    }

    private void OnDestroy()
    {
        ReportAngle();
        HideSpot();
    }

    void CacheComponents()
    {
        //
        _selfRenderer = GetComponent<Renderer>();
        Debug.Log($"CacheComponents 메서드 {_selfRenderer}");
    }

    void InitAngle()
    {
        _angle = _startAngle;
        Debug.Log(_angle);
    }

    void ActivateVisual()
    {
        
        _selfRenderer.enabled = _selfRenderer;
        _selfRenderer.enabled = _baseRenderer;
        Debug.Log($"{_selfRenderer}를 켰습니다");
        Debug.Log($"{_baseRenderer}를 켰습니다");
    }

    void BindSpot()
    {
        
    }

    void TurnExhibit()
    {
        _angle += _turnPerFrame;
    }

    void DeactivateVisual()
    {
        Debug.Log($"{_selfRenderer}를 껐습니다");
        Debug.Log($"{_baseRenderer}를 껐습니다");
    }

    void ReportAngle()
    {
        Debug.Log(_angle);
    }

    void HideSpot()
    {
        Debug.Log($"{_spotRenderer}를 껐습니다");
    }
}
