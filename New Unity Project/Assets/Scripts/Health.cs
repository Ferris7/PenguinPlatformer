using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    Text healthText;
    public static GameObject healthCounter;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        healthCounter = GameObject.FindGameObjectWithTag("Health");

        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health.ToString();
    }
}
