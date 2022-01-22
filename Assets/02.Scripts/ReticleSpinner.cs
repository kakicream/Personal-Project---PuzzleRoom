using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleSpinner : MonoBehaviour
{
    [SerializeField] private float spinSpeed = 30.0f;
    
    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed*Time.deltaTime);        
    }
}
