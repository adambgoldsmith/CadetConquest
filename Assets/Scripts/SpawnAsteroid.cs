using UnityEngine;
using System.Collections;

public class SpawnAsteroid : MonoBehaviour
{

    public GameObject Asteroid;


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Instantiate(Asteroid, transform.position, Quaternion.identity);
            
	}
}
