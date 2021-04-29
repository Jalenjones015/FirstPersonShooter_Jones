using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public bool Winning;
    public GameObject Finish;

    public void win(GameObject obj)
    {
        if (!Winning)
        {
            WinGame game = obj.GetComponent<WinGame>();
            if (game)
            {
                if (game.Collected == 0)
                {
                    Winning = true;
                    Finish.SetActive(true);
                    game.Gamedone();
                    Debug.Log("won");
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
            }
        }
    }
}
