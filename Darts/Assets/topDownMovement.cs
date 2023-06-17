using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topDownMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime;
        float v = Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(h, v, 0);
    }
}
