using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleScript : MonoBehaviour
{
    [SerializeField] private Vector3 localPosFactors = Vector3.one;
    [SerializeField] private Vector3 localRotFactors = Vector3.one;
    [SerializeField] private float massFactor = 1f;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(localPosFactors.x * Time.time),
            Mathf.Sin(localPosFactors.y * Time.time),
            Mathf.Sin(localPosFactors.z * Time.time));
        
        transform.Rotate(new Vector3(Mathf.Sin(localRotFactors.x * Time.time),
            Mathf.Sin(localRotFactors.y * Time.time),
            Mathf.Sin(localRotFactors.z * Time.time)));

        _rb.mass = Mathf.Sin(massFactor * Time.time);
    }
}
