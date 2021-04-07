using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pause : MonoBehaviour
{
    bool ispaused = false;
    public GameObject pausemenu;
    public GameObject allon;
    public UnityEvent pauseing;
    public KeyCode escape;

    private void Update()
    {
        if(Input.GetKeyDown(escape))
        {
            pauseing.Invoke();
        }
    }

    public void Pausep()
    {
        if (ispaused)
        {
            Time.timeScale = 1;
            ispaused = false;
            Debug.Log("unpause");
            pausemenu.SetActive(false);
            allon.SetActive(true);
            GameObject var = GameObject.Find("Player");
            var.GetComponent<Mouse>().enabled = true;
            var.GetComponent<Movement>().enabled = true;
        }
        else if(!ispaused)
        {
            Time.timeScale = 0;
            ispaused = true;
            Debug.Log("pause");
            pausemenu.SetActive(true);
            allon.SetActive(false);
            GameObject var = GameObject.Find("Player");
            var.GetComponent<Mouse>().enabled = false;
            var.GetComponent<Movement>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}