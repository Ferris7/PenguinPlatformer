/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCollision : MonoBehaviour
{
    public static bool won = false;
    //private int health = 7;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 9)
        {
            SnowballCounter.snowballAmount++;
            Destroy(other.gameObject);

        }

        if (other.gameObject.layer == 10)
        {
            won = false;
            FindObjectOfType<GameManager>().EndGame();

            //thisAnim.SetTrigger("stun");
            //health--;

            //if (health == 0)
            //{
            //Destroy(gameObject);
            //}
        }

        if (other.gameObject.layer == 11)
        {
            won = true;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
*/