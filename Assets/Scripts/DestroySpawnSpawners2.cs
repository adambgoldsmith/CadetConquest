using UnityEngine;
using System.Collections;

public class DestroySpawnSpawners2 : MonoBehaviour
{
    public GameObject AsteroidSpawner2;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (AsteroidSpawner2 != null)
        {
            DestroyImmediate(AsteroidSpawner2, true);
        }
    }
}
