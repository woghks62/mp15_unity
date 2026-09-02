using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycleProbe : MonoBehaviour
{
    float _elapsed = 0;
    private void Awake()
    {
        Debug.Log("LifeCycleProbe: Awake");
    }

    private void OnEnable()
    {
        Debug.Log("LifeCycleProbe: OnEnable");
    }

    private void Start()
    {
        Debug.Log("LifeCycleProbe: Start");
    }

    private void FixedUpdate()
    {
        Debug.Log("LifeCycleProbe: FixedUpdate");
    }

    private void Update()
    {
        Debug.Log("LifeCycleProbe: Update");
        _elapsed += Time.deltaTime;
    }

    private void LateUpdate()
    {
        Debug.Log("LifeCycleProbe: LateUpdate");
    }

    private void OnDisable()
    {
        Debug.Log("LifeCycleProbe: OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("LifeCycleProbe: OnDestroy");
    }

    //private void Awake() => LogStep("Awake");
    //private void OnEnable() => LogStep("OnEnable");
    //private void Start() => LogStep("Start");
    //private void OnDisable() => LogStep("OnDisable");
    //private void OnDestroy() => LogStep("OnDestroy");

    //private void LogStep(string stepName)
    //{
    //    Debug.Log($"LifeCycleProbe: {stepName}");
    //}
}
