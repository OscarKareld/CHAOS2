using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomGrowth : MonoBehaviour
{
    public float x = 1;
    public float y = 0;
    public float z = 1;

    public int counter = 1;

    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float growth = Time.deltaTime * 10;
        counter++;
        if ((counter % 10) == 0) {
            transform.localScale = new Vector3(x += growth, y += growth, z += growth);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Car")
        {
            GameObject car = collider.gameObject;
            CarController carcontroller = car.GetComponentInParent<CarController>();
            if (carcontroller != null)
            {
                Debug.Log("collided with");
            }
            Destroy(gameObject);
        }
    }
}

