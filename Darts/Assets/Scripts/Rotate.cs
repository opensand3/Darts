using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float spinSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime); 
    }
}
