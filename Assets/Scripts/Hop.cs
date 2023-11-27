using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hop : MonoBehaviour
{
    public Rigidbody rb;
    public AudioSource springsnd;

    void OnTriggerStay()
    {
        rb.AddForce(1000,2000,0, ForceMode.Impulse);
    }

    void OnTriggerEnter()
    {
        springsnd.Play();
    }
}
