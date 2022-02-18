using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    //[SerializeField] private float mass;
    //[SerializeField] public float currhealth;

    //private void Awake()
    //{
    //    currhealth = mass;
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bubblet"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale--;
        }
    }
}
