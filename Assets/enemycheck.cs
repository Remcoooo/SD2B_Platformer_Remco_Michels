using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemycheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject enemies;
        enemies = GameObject.FindGameObjectWithTag("Enemy");
        if (enemies == null)
        {
            SceneManager.LoadScene(sceneBuildIndex: 2);
        }
    }
}
