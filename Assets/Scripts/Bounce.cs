using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 lastVelocity;
    
    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("coll"))
        {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, other.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
        }    
    }
}
