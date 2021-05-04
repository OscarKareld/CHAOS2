using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class CarController : MonoBehaviour
{
    public float acceleration = 20.0f;
    public Rigidbody m_rigidbody;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;

    public int maxHealth = 50;
    public int currentHealth;
    public HealthBar healthBar;
    private float oldVel;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        Vector3 vel = m_rigidbody.velocity;
       // vel += transform.right * horizontalInput * acceleration * Time.deltaTime;
       // vel.y += 0;
        vel += transform.forward*forwardInput * acceleration * Time.deltaTime;

        //transform.Translate(Vector3.forward*Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        m_rigidbody.velocity = vel;
       oldVel = m_rigidbody.velocity.magnitude;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= Mathf.Clamp((int)(damage* oldVel*0.6),1,5);
        if (CheckHealth())
        {
            healthBar.SetHealth(currentHealth);
        }
        Debug.Log("Car health is " + currentHealth);
    }

    public void IncrementHealth(int healthPoints)
    {
        if (CheckHealth()) {
            currentHealth += healthPoints;
            healthBar.SetHealth(currentHealth);
        }
        Debug.Log("IncHealth: Car health is " + currentHealth);
    }
    
    public bool CheckHealth()
    {
        if (currentHealth <= 0 || currentHealth == maxHealth)
            return false;
        else
            return true;
    }

}
