using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 10f,0f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.CompareTag("Car"))
        {
            CarController cc = other.transform.GetComponentInChildren<CarController>();
            if (cc != null)
            {
                Debug.Log("collided with");
                //öka hp med x;
            }

            
            
            Destroy(gameObject);
        }
    }
}
