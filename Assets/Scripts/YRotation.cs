using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YRotation : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speed));
    }
}
