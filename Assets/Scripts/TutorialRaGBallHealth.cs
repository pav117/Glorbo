using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialRaGBallHealth : MonoBehaviour
{
    public float health = 50f;
    public GameObject Door;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Destroy(Door);
    }
}
