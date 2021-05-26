using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnSpawners : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();

    public GameObject AsteroidSpawner1;
    public GameObject AsteroidSpawner2;

    public float currentTime = 1.0f;
    public float currentTimer = 0.0f;


    // Use this for initialization
    void Start ()
    {
        StartCoroutine(ChangeInterval());
    }
	
	// Update is called once per frame
	void Update ()
    {
        currentTimer += 0.01f;

        if (currentTimer >= currentTime)
        {
            prefabList.Add(AsteroidSpawner1);
            prefabList.Add(AsteroidSpawner2);

            int prefabIndex = UnityEngine.Random.Range(0, 2);
            Instantiate(prefabList[prefabIndex]);
            currentTimer = 0.0f;
        }
    }

    IEnumerator ChangeInterval()
    {
        if (currentTime >= 0.5f)
        {
            yield return new WaitForSeconds(15);
            currentTime -= 0.10f;
            StartCoroutine(ChangeInterval());
        }
    }

}
