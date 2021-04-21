using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    public GameObject e;


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door")
        {
            e.SetActive(true);
            Animator anim = other.GetComponent<Animator>();

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("You Press E");
                anim.SetTrigger("Opening");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
        {
            e.SetActive(false);
        }
    }
}
