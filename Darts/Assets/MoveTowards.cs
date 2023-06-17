using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public GameObject target;
    public float speedEnemy;
    public GameObject myPrefab;

    private void Start()
    {
        Instantiate(myPrefab, new Vector3(1, 0, 0), Quaternion.identity);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speedEnemy * Time.deltaTime);
    }
}
