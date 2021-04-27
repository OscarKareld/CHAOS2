using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10f, 0f,0f * Time.deltaTime);
    }
}
