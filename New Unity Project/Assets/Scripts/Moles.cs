using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moles : MonoBehaviour
{
    //private int health = 3;
    private Animator thisAnim;

    // Start is called before the first frame update
    void Start()
    {
        thisAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            //thisAnim.SetTrigger("mole_attack");
            //health--;

            //if (health == 0)
            //{
                Destroy(gameObject);
            //}
        }
    }
}