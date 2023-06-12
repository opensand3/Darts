using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dart : MonoBehaviour
{
    [SerializeField] float dartSpeed;

    public void Fire()
    {
        // Type name = Get the rigid body component from the same Game Object 
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * dartSpeed;
    }

    // autocomplete by searching oncollision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Dart>() != null)
        {
            SceneManager.LoadScene(0);
        }


        // stop moving and become a child of the Target
        transform.SetParent(collision.transform);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true; // only move this with our code

        // find our score counter
        var scoreCounter = FindObjectOfType<ScoreCounter>();
        scoreCounter.AddPoint();
    }
}
