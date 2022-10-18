using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public float healthPlayer = 2f;
    private float currentHealthPlayer;
    // Start is called before the first frame update
    void Start()
    {
        currentHealthPlayer = healthPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealthPlayer = healthPlayer;
        if(currentHealthPlayer <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit");
            healthPlayer--;
        }
    }
}
