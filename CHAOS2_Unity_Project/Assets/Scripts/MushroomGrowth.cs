using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomGrowth : MonoBehaviour
{
    public float x = 1;
    public float y = 0;
    public float z = 1;

    public int counter = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float growth = Time.deltaTime * 100;
        counter++;
        if ((counter % 100) == 0) {
            transform.localScale = new Vector3(x += growth, y += growth, z += growth);
        }
    }
}
