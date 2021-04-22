using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent en;
    public GameObject Player;
    public float range;
    public Animator animator;
    public bool running;

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
            animator.SetBool("Running", true);
        }

        if (!chase)
        {
            en.SetDestination(transform.position);
            animator.SetBool("Running", false);
        }
    }
}
