using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public GameObject bullet;
    private float facingDirX = 1;
    public float Jumpforce = 1;
    private Rigidbody2D _rigidbody;
    private Vector3 respawnPoint;
    public GameObject FallDetector;

    // Update is called once per frame
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        respawnPoint = transform.position;
    }

    void Update()
    {

        // Walk horizontal
        float dirX = Input.GetAxisRaw("Horizontal");

        transform.Translate(transform.right * dirX * speed * Time.deltaTime);

        // Shoot on left mouse button

        if (dirX == -1 || dirX == 1)
        {
            facingDirX = dirX;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject spawnBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnBullet.GetComponent<Bullet>().dirX = facingDirX;
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001)
        {
            _rigidbody.AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
        }

        FallDetector.transform.position = new Vector2(transform.position.x, FallDetector.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FallDetector")
        {
            transform.position = respawnPoint;
        }
    }
}
