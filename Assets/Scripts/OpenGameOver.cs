using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenGameOver : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public AsteroidCollision asteroidCollision;
    public bool playerDead = false;
    public GameObject gameoverPanel;
    public Text smallScore;

	// Use this for initialization
	void Start ()
    {
        gameoverPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (playerDead == false)
        {
            gameoverPanel.SetActive(true);
        }
	}
}
