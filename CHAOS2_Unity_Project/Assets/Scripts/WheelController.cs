using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 10f, 0f * Time.deltaTime);
  
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Car")
        {
            GameObject car = collider.gameObject;
            CarController carcontroller = car.GetComponentInParent<CarController> ();
            if (carcontroller != null)
            {
                Debug.Log("collided with");
                carcontroller.IncrementHealth(10);
            }         
            Destroy(this.gameObject);
        }
    }
}
