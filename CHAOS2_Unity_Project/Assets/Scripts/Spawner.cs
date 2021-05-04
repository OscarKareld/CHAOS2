using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] float spawnDelay;

    [SerializeField] float offset = 0;

    [Header("MapBounds")]
    [SerializeField] float x_min;
    [SerializeField] float x_max;
    [SerializeField] float z_min;
    [SerializeField] float z_max;


    float cooldown;

    // Update is called once per frame
    void Update()
    {
        if (cooldown <= 0)
        {
            
            Vector3 desiredPos = new Vector3(Random.Range(x_min, x_max), offset, Random.Range(z_min, z_max));
			NavMeshHit hit;
			if (NavMesh.SamplePosition(desiredPos, out hit, 1.0f, NavMesh.AllAreas)) {
                cooldown += spawnDelay;
                desiredPos = hit.position;
                desiredPos.y = offset;
				GameObject.Instantiate(spawnObject, desiredPos, Quaternion.identity, transform);

			}
        }
        cooldown -= Time.deltaTime;
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(new Vector3(x_min, 2, z_min), new Vector3(x_max, 2, z_max));
    }
}
