using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame1()
    {
        SceneManager.LoadScene("L1");
        Debug.Log("Start1");
        Time.timeScale = 1;
    }

    public void StartGame2()
    {
        SceneManager.LoadScene("L2");
        Debug.Log("Start2");
        Time.timeScale = 1;
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        Debug.Log("credits");
    }

    public void Howto()
    {
        SceneManager.LoadScene("How To");
        Debug.Log("how to");
    }

    public void close()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void back()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("meu");
    }

    public void restart1()
    {
        SceneManager.LoadScene("L1");
        Debug.Log("restrat");
        Time.timeScale = 1;

    }

    public void restart2()
    {
        SceneManager.LoadScene("L2");
        Debug.Log("restrat");
        Time.timeScale = 1;

    }
}
