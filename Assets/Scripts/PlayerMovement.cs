using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    public float thrust;
    public Rigidbody2D rb;
    public OpenGameOver openGameOver;
    public float deathSpeed = 15.0f;
    public bool playerMovementEnabled = false;
    public float speedStart = 0.15f;
    public AudioClip jetpackSound;
    public Camera mainCamera;
    public AudioSource mySound;


    public Transform target;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (playerMovementEnabled == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, 5.0f * Time.deltaTime);

            if (transform.position == target.position)
            {
                rb.gravityScale = 1.65f;
                playerMovementEnabled = true;
            }
        }

        if (playerMovementEnabled == true)
        {
            if (Input.GetKey("space"))
            {
                rb.AddForce(transform.up * thrust);
            }
            
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Stationary)
                {
                    rb.AddForce(transform.up * thrust);

                    mySound.enabled = true;
                    mySound.loop = true;
                }

            }
            else
            {
                mySound.enabled = false;
                mySound.loop = false;
            }


            if (Input.GetMouseButton(0))
            {
                rb.AddForce(transform.up * thrust);

            }


            openGameOver = GameObject.Find("GameOverPanel").GetComponent<OpenGameOver>();
            if (openGameOver.playerDead == false)
            {
                rb.transform.Translate(Vector2.left * speedStart * Time.deltaTime);
            }
        }
    }
}
