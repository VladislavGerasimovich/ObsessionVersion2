using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _rotationSpeed = 0.2f;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * _speed *  Time.deltaTime);
        transform.Rotate(0, _rotationSpeed, 0 );
    }
}
