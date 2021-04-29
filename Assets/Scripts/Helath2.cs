using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Helath2 : MonoBehaviour
{
    public int maxHP = 20;
    public int curHP;
    public HealthBar healthBar;
    public GameObject lose;
    bool isdead = false;

    private void Start()
    {
        curHP = maxHP;
        healthBar.SetHP(maxHP);
    }

    private void Update()
    {
        Lose();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeHP(2);
        }
    }

    void TakeHP(int damage)
    {
        curHP -= damage;
        healthBar.SetHP(curHP);
    }

    void Lose()
    {
        if (curHP <= 0)
        {
            SceneManager.LoadScene("Lose 2");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
