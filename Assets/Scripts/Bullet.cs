using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;
    public float lifeTime = 3;
    public float dirX = 1f;

    // Update is called once per frame
    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.Translate(transform.right * dirX * speed * Time.deltaTime);
    }
}
