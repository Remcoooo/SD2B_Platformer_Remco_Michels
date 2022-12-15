using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndscreenButton : MonoBehaviour
{
    public void nextScene(string scene)
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
