using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] float spawnDelay;

    float cooldown;

    // Update is called once per frame
    void Update()
    {
        if (cooldown <= 0)
        {
            cooldown += spawnDelay;
            GameObject.Instantiate(spawnObject, new Vector3(0, 0, 0), Quaternion.identity);
        }
        cooldown -= Time.deltaTime;
    }
}
