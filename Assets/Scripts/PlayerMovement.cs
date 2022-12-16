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
    float inputHorizontal;
    AudioSource shootingSound;

    // Update is called once per frame
    private void Start()
    {
        shootingSound = GetComponent<AudioSource>();
        _rigidbody = GetComponent<Rigidbody2D>();
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
            shootingSound.Play();
            GameObject spawnBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnBullet.GetComponent<Bullet>().dirX = facingDirX;
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001)
        {
            _rigidbody.AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");

        if(inputHorizontal > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        if (inputHorizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}