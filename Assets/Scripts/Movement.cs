using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{    public KeyCode right;
    public KeyCode left;
    public KeyCode foward;
    public KeyCode back;
    public GameObject player;
    public float speed;

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
    }
}
