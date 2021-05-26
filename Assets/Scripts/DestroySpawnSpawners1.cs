using UnityEngine;
using System.Collections;

public class DestroySpawnSpawners1 : MonoBehaviour
{
    public GameObject AsteroidSpawner1;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (AsteroidSpawner1 != null)
        {
            DestroyImmediate(AsteroidSpawner1, true);
        }
    }
}
