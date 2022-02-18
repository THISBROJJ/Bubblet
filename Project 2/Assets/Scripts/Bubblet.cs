using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubblet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Danger"))
            {
                Collide(collision.gameObject, collision);
            }
        }

    private void Collide(GameObject Danger, Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().mass == 1)
        {
            Danger.GetComponent<Rigidbody2D>().gravityScale-=2;
        }
        else
        {
            Danger.GetComponent<Rigidbody2D>().mass--;
            Destroy(gameObject);
        }
    }

}
