using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            collision.gameObject.SetActive(false);
        }
        if (collision.CompareTag("EnemyBullet"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
