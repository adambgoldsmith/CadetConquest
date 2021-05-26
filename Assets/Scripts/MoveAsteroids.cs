using UnityEngine;
using System.Collections;

public class MoveAsteroids : MonoBehaviour
{
    public GameObject Asteroid;

    public float speed = 15.0f;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        Destroy(Asteroid, 4);
	}
}
