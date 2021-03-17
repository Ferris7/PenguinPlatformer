/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    [SerializeField] private Transform pfBullet;

    public float speed = 10.0f;
    private Rigidbody rb;
    private Vector3 screenBounds;

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed, 0, 0);
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Penguin.xPos + Screen.width, Screen.height, 1));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Penguin.xPos + 5 * -2)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 10)
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
*/