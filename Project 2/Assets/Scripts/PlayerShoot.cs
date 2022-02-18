using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject BubbletPrefab;
    public PlayerHealth script;
    public float maxhealth = 6;

    private void Update()

    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject Bubblet = Instantiate(BubbletPrefab, transform.position, transform.parent.rotation);
        Bubblet.GetComponent<Rigidbody2D>().AddForce(transform.up * 320);
        script.currhealth -= 0.5f;
        Debug.Log("Health is now " + script.currhealth);
        script.HPSlider.value = script.currhealth / maxhealth;
        if (script.currhealth <= 0)
        {
            Debug.Log("gameover");
        }
    }
}
