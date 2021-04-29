using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WinGame : MonoBehaviour
{
    public int Collected;
    public Text Pages;

    private void Start()
    {
        Collected = 0;
    }

    private void Update()
    {
        Pages.text = Collected.ToString();
        Pages.text = "Pages Collected: " + Collected;
    }

    public void Pape()
    {
        Collected++;
    }

    public void Gamedone()
    {
        SceneManager.LoadScene("Win");
        Debug.Log("won");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
