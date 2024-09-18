using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameMenu : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene(1);
    }
}
