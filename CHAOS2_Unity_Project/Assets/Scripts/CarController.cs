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

    public int maxHealth = 20;
    public int currentHealth;
    public HealthBar healthBar;

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
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (CheckHealth())
        {
            healthBar.SetHealth(currentHealth);
        }
        Debug.Log("Car health is " + currentHealth);
    }

    public void IncrementHealth(int damage)
    {
        if (CheckHealth()) {
            currentHealth += damage;
            healthBar.SetHealth(currentHealth);
        }
        Debug.Log("Car health is " + currentHealth);
    }
    
    public bool CheckHealth()
    {
        if (currentHealth <= 0 || currentHealth == 20)
            return false;
        else
            return true;
    }

}
