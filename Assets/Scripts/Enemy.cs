using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    public GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    public void Update()
    {
        Vector3 position = player.transform.position - transform.position;
        position = position.normalized;
        transform.Translate(position.x * Time.deltaTime * Speed, position.y * Time.deltaTime * Speed, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Debug.Log("PlayerGone");
        }
    }

}
