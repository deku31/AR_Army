using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonMenu : MonoBehaviour
{
    public void changeScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
    public void exit()
    {
        Application.Quit();
    }
}
