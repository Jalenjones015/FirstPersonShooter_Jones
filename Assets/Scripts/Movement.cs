using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{    public KeyCode right;
    public KeyCode left;
    public KeyCode foward;
    public KeyCode back;
    public KeyCode jump;
    public GameObject player;
    public float speed;
    public Rigidbody rig;
    public bool jumpin = true;

    private void FixedUpdate()
    {
        if (Input.GetKey(right))
        {
            player.transform.Translate(new Vector2(speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(left))
        {
            player.transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(foward))
        {
            player.transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }

        if (Input.GetKey(back))
        {
            player.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }

        if (Input.GetKeyDown(jump) && jumpin)
        {
            rig.AddForce(new Vector2(0, 11), ForceMode.Impulse);
            jumpin = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            jumpin = true;
        }
    }
}
