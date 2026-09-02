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

    private const string TAG = "Spot";

    private void Awake()
    {
        CacheComponents();
        InitAngle();
    }

    private void OnEnable()
    {
        ActivateVisual();
    }

    void Start()
    {
        BindSpot();
    }

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
        Debug.Log(_selfRenderer.name);
    }

    void InitAngle()
    {
        _angle = _startAngle;
        Debug.Log(_angle);
    }

    void ActivateVisual()
    {
        _selfRenderer.enabled = true;
        _baseRenderer.enabled = true;
        Debug.Log("_selfRenderer, _baseRenderer 켰습니다");
    }

    void BindSpot()
    {
        GameObject gameobject = GameObject.FindWithTag(TAG);
        _spotRenderer = gameobject.GetComponent<Renderer>();

        Debug.Log(_spotRenderer.name);
    }

    void TurnExhibit()
    {
        _angle += _turnPerFrame;
    }

    void DeactivateVisual()
    {
        _selfRenderer.enabled = false;
        _baseRenderer.enabled = false;
        Debug.Log("_selfRenderer, _baseRenderer 껐습니다");
    }

    void ReportAngle()
    {
        Debug.Log(_angle);
    }

    void HideSpot()
    {
        _spotRenderer.enabled = false;
        Debug.Log("_spotRenderer 껐습니다");
    }
}