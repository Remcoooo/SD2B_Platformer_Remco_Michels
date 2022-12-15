using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;
    public float lifeTime = 3;
    public float dirX = 1f;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.Translate(transform.right * dirX * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Enemy enemyScript = collision.gameObject.GetComponent<Enemy>();

            enemyScript.takeDamage();
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("MapTiles"))
        {
            Bullet BulletScript = collision.gameObject.GetComponent<Bullet>();
            Destroy(gameObject);
        }
    }
}
