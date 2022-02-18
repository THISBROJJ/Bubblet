using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    private float maxhealth = 6;
    public float currhealth;
    public Slider HPSlider;
    //public GameObject BubbletPrefab;


    private void Awake() {
        currhealth = maxhealth;
        HPSlider.value = currhealth / maxhealth;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Danger"))
        {
            currhealth -= collision.gameObject.GetComponent<Rigidbody2D>().mass;
            HPSlider.value = currhealth / maxhealth;
            Debug.Log("Health is now " + currhealth.ToString());

            if (currhealth <= 0)
            {
                Debug.Log("gameover");
            }
        }
        else if (collision.gameObject.CompareTag("Refillable"))
        {
            currhealth += 3;
            currhealth = Mathf.Min(currhealth, maxhealth);
            HPSlider.value = currhealth / maxhealth;
            Debug.Log("Health is now " + currhealth.ToString());
            Destroy(collision.gameObject);
        }
    }

}
