using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private Vector3 _scaleChange;

    private void Start()
    {
        _scaleChange = new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed);
    }

    private void Update()
    {
        transform.localScale += _scaleChange;
    }
}
