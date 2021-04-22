using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int maxHPs = 2;
    public int curHPs;
    bool isdeads = false;

    private void Start()
    {
        curHPs = maxHPs;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeHPs(1);
        }
    }

    void TakeHPs(int damage)
    {
        curHPs -= damage;
        if(curHPs <= 0)
        {
            Destroy(gameObject);
        }
    }
}
