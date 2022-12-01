using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundExample : MonoBehaviour
{
    public GameObject explosionEffect;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            RunPInput();
        }
    }

    private void RunPInput()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
    }
}
