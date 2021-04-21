using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent en;
    public GameObject Player;
    public float range;

    void Start()
    {
        en = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float dist = Vector3.Distance(Player.transform.position, this.transform.position);
        bool chase = (dist < range);

        if (chase)
        {
            float random = Random.Range(0.0f, 1.0f);
            en.SetDestination(Player.transform.position);
        }

        if (!chase)
        {
            en.SetDestination(transform.position);
        }
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireSphere(transform.position, range);
    //}
}
