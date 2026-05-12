using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public int levelIndex = 1;

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelIndex);
    }
}