using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenchange : MonoBehaviour
{
    public Renderer rend;
    public Material[] material;
    public AudioSource dio;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            rend.sharedMaterial = material[1];
            dio.GetComponent<AudioSource>().Play();
        }
    }
}
