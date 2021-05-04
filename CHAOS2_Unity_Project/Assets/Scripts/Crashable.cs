using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crashable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Car")
        {
            GameObject car = collision.gameObject;
            CarController carController = car.GetComponent<CarController>();
            carController.TakeDamage(1);

        }
    }

}
