using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SnowballCounter : MonoBehaviour
{
    Text counterText;
    public static GameObject Counter;
    public static int snowballAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>();
        Counter = GameObject.FindGameObjectWithTag("Snowballs");
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = "Snowballs: " + snowballAmount.ToString();
    }
}
