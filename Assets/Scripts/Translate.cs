using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    private float _speed = 1;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed *  Time.deltaTime);
    }
}
