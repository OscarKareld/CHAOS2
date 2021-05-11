using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WarningText : MonoBehaviour
{
    public static UnityEvent showText = new UnityEvent();

    private float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

       // showText.AddListener(activate);
    }

/*
    void Update()
 {
     timeRemaining -= Time.deltaTime;

     if (timeRemaining <= 0) {
         gameObject.SetActive(false);
     }
 }
    void activate() {
        gameObject.SetActive(true);
    
        timeRemaining = 2;
    }
    */
}
