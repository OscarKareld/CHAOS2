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

    private void OnTriggerEnter(Collider car)
    {
        if (car.transform.gameObject.CompareTag("Car"))
        {
            Debug.Log("Inne i första if-satsen");
            CarController cc = car.transform.GetComponentInChildren<CarController>();
            if (cc != null)
            {
                Debug.Log("collided with");
                cc.IncrementHealth(10);
            }         
            Destroy(gameObject);
        }
    }
}
