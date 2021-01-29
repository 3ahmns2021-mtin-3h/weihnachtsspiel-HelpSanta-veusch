using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    int countCollision = 0;
    public bool carringNut = false;
    public bool carringGift = false;
    public int points = 0;
    public GameObject feedbackchildGift;
    public TextMeshProUGUI scoreDisplay;


  


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.Contains("Enemy"))
        {
            Destroy(collision.gameObject);
            carringNut = true;
            feedbackchildGift.SetActive(true);
            points--;
            points--;
            scoreDisplay.text = points.ToString();
            carringNut = false;
            feedbackchildGift.SetActive(false);
          
        }

        else if (collision.name == "Enemy2")
        {
            countCollision--;
        }

        else if (collision.name.Contains ("Geschenk") && !carringNut)
        {
            Destroy(collision.gameObject);
            carringNut = true;
            feedbackchildGift.SetActive(true);
            points++;
            scoreDisplay.text = points.ToString();
            carringNut = false;
            feedbackchildGift.SetActive(false);
        }


        Debug.Log("Trigger Hallo Player collide with" + collision.name);
    }
}
