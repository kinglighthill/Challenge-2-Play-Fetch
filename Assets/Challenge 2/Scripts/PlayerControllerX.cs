using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool spawnDog = true;
    private float spawnDelay = 3.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (spawnDog && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnDog = false;

            Invoke("SetSpawn", spawnDelay);
        }
    }

    void SetSpawn()
    {
        spawnDog = true;
    }
}
