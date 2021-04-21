using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Tim : MonoBehaviour
{
    private float timer = 180;
    public Text display;

    private void Update()
    {
        timer = timer - Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        display.text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
        lose();
    }

    private void lose()
    {
        if (timer <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
