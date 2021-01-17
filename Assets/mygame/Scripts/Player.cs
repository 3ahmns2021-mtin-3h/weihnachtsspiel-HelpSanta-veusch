using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    int countCollision = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name=="Enemy")
        {
            countCollision--;
        }

        else if (collision.name == "Enemy2")
        {
            countCollision--;
        }

        else if (collision.name == "Geschenk")
        {
            countCollision++;
        }


        Debug.Log("Trigger Hallo Player collide with" + collision.name);
    }
}
