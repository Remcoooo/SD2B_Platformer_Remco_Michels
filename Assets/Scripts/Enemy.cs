using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float dirX = 1f;
    public int hp = 2;
    public float speed = 5;
    bool isAlive = true;

    void Update()
    {
        if (isAlive)
        {
            transform.Translate(transform.right * dirX * speed *  Time.deltaTime);

            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right * dirX, 0.6f);

            Debug.DrawRay(transform.position, transform.right * 0.6f * dirX, Color.blue);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.CompareTag("wall"))
            {
                dirX *= -1f;
            }
        }
    }

    public void takeDamage()
    {
        hp--;
        if (hp <= 0)
        {
            Die();
            
        }
    }

    void Die()
    {
        ScoreSystem.score += 1;
        Destroy(gameObject);
        //isAlive = false;
        //animate.SetBool("isAlive", isAlive);
    }
}
