using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MushroomGrowth : MonoBehaviour
{
    public float x = 1;
    public float y = 0;
    public float z = 1;

    public float growthCounter = 1f;

    private float redCounter = 5f; //typ 20 sen

    private float warningTextCountdown = 2f;

    public Color color;

    private bool warningIsShowing= false;


    private Image warText;
    // Start is called before the first frame update
    void Start()
    {
        warText = GameObject.FindGameObjectWithTag("Warning").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        float growth = Time.deltaTime * 100;
        
        growthCounter -= Time.deltaTime;
        redCounter -= Time.deltaTime;
        if (growthCounter <= 0) {
            transform.localScale = new Vector3(x += growth, y += growth, z += growth);
            growthCounter = 1f;
        }

        if (redCounter <= 0) { 
            var mesh = GetComponentInChildren<MeshRenderer>();
            mesh.material.color = Color.red;
            warningTextCountdown -= Time.deltaTime;
            
            //warningText.showText();
            if (warningIsShowing == false) {
                warText.enabled = true;
                warningIsShowing = true;
            }
            

            if (warningTextCountdown <= 0 && warningIsShowing == true) {
                warText.enabled = false;
                warningTextCountdown = 300;
            }
            
            //TODO: Lägg till game over när någon counter når X. 
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

