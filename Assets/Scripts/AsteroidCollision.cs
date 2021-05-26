using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AsteroidCollision : MonoBehaviour
{
    public GameObject Asteroid;
    public GameObject Astronaut;
    public PlayerMovement playerMovement;
    public OpenGameOver openGameOver;
    public ScoreManager scoreManager;
    public float stopPoints = 0.0f;
    public AudioSource deathSound;
    public float deathDelay = 2.0f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            openGameOver = GameObject.Find("GameOverPanel").GetComponent<OpenGameOver>();
            openGameOver.playerDead = false;
            scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
            scoreManager.scoreIncreasing = false;
            deathSound.enabled = true;
            Destroy(Astronaut, deathDelay);
        }
    }

    // Use this for initialization
    void Start ()
    {
          
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

}
