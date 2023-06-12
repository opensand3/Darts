using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartLauncher : MonoBehaviour
{
    // Type name
    [SerializeField] Dart dartPrefab;
    [SerializeField] Dart currentlyLoadedDart;

    void Start()
    {
        // call SpawnDart function
        SpawnDart();    
    }

    void SpawnDart()
    {
        // Instantiate(variable, Vector3 position, ?);
        // Instantiate returns the Dart we have spawned. We can assigned this with a new variable (currentlyLoadedDart) assigned to the Instantiate
        currentlyLoadedDart = Instantiate(dartPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, -90)));
    }

    void Update()
    {
        if (Input.touchCount == 0)
        {
            return;
        }

        Touch touch = Input.GetTouch(0);

        // controls
        if (currentlyLoadedDart != null && touch.phase == TouchPhase.Began)
        {
            currentlyLoadedDart.Fire();
            currentlyLoadedDart = null;

            // spawn a new dart after 1 second and reset this currently loaded dart
            Invoke(nameof(SpawnDart), 1);
        }
            
    }
}