using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Penguin : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private GameObject pfBullet;

    private bool jumpKey = false;
    private bool doubleJump = false;
    private float HorizontalInput;
    private Rigidbody rigidbodyComponent;
    public static bool won;
    public static bool dead = false;
  
    private Animator thisAnim;

    public Transform spawnTransform;

    //Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
        thisAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jumpKey = true;
        }

        HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0)
        {
            thisAnim.SetTrigger("Walk");
        }
        else
        {
            thisAnim.SetTrigger("Idle");
        }

        if (StartButton.notShowing)
        {
            SnowballCounter.Counter.SetActive(true);
            Health.healthCounter.SetActive(true);
        }
        else
        {
            SnowballCounter.Counter.SetActive(false);
            Health.healthCounter.SetActive(false);
        }

        if (dead)
        {
            showEnd();
        }

    }

    private void FixedUpdate()
    {
        if (rigidbodyComponent.position.y < -1f)
        {
            won = false;
            dead = true;
            FindObjectOfType<GameManager>().EndGame();
        }

        rigidbodyComponent.velocity = new Vector3(HorizontalInput * 3, rigidbodyComponent.velocity.y, 0);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            if (doubleJump && jumpKey)
            {
                rigidbodyComponent.AddForce(Vector3.up * 3, ForceMode.VelocityChange);
                doubleJump = false;
            }
            return;
        }

        if (jumpKey)
        {
            thisAnim.SetTrigger("jump");
            rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKey = false;
            doubleJump = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            SnowballCounter.snowballAmount++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.layer == 11)
        {
            won = true;
            dead = true;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void showEnd()
    {

        GameOver.GameOverMenu.SetActive(true);
        GameOver.BG.SetActive(true);


        if (Penguin.won)
        {
            GameOver.Won.SetActive(true);
        }
        else
        {
            GameOver.Lost.SetActive(true);
        }


    }

    public void Fire()
    {
        var go = Instantiate(pfBullet);
        go.transform.position = new Vector3(rigidbodyComponent.position.x, rigidbodyComponent.position.x, 0);
        var bullet = go.GetComponent<Bullet>();
        bullet.Fire(go.transform.position, spawnTransform.eulerAngles, gameObject.layer);

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 10)
        {
            thisAnim.SetTrigger("stun");
            Health.health--;

            if (Health.health == 0)
            {
                won = false;
                dead = true;
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        if (other.gameObject.layer == 12)
        {
            thisAnim.SetTrigger("stun");
            Health.health-=2;

            if (Health.health == 0)
            {
                won = false;
                dead = true;
                FindObjectOfType<GameManager>().EndGame();
            }
        }

    }

}
