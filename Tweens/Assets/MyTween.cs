using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTween : MonoBehaviour
{ 
    [SerializeField] AnimationCurve curve;
    [SerializeField] private float duration = 5;
    [SerializeField] private Vector3 startPos, endPos = Vector3.one;

    void Update()
    {
        Tween();
    }
    void Tween()
    {
        float t = Time.time / duration;
        transform.position = Vector3.Lerp(startPos, endPos, curve.Evaluate(t));
    }
}
