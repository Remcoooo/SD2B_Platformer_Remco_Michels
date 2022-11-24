using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float dirX = 1f;
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * dirX * speed *  Time.deltaTime);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right * dirX, 0.6f);

        Debug.DrawRay(transform.position, transform.right * 0.6f * dirX, Color.blue);


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
}
