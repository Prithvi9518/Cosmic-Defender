using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health playerHealth = collision.GetComponent<Health>();

        if(playerHealth!=null)
        {
            if(playerHealth.currentLives<playerHealth.maximumLives)
            {
                playerHealth.currentLives++;
                Destroy(gameObject);
            }
        }
    }
}
