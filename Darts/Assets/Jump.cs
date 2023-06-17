using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    [SerializeField] float jForce = 1f;
    [SerializeField] float speed;
    Rigidbody2D rb;

    [SerializeField] private LayerMask groundLayer;
    private int availableJumps;
    private int maxJumpsAvailable = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.Translate(h, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && availableJumps > 0)
        {
            PlayerJump();
            availableJumps--;
        }   
    }

    private void PlayerJump()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * jForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == groundLayer.value)
        {
            // Player touched the ground
            availableJumps = maxJumpsAvailable;
        }
    }
}
