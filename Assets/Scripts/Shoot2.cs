using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot2 : MonoBehaviour
{
    public Transform point;
    public GameObject bulletpre;
    public float bullforce = 1f;
    public float betweenshots = .1f;
    private float tim = 0f;

    void Update()
    {
        if ((Input.GetButton("Fire1") && (Time.time >= tim)))
        {
            shoot();
            tim = Time.time + betweenshots;
        }
    }

    public void shoot()
    {
        GameObject bullet = Instantiate(bulletpre, point.position, point.rotation);
        Rigidbody rigid = bullet.GetComponent<Rigidbody>();
        rigid.AddForce(point.up * bullforce, ForceMode.Impulse);
        Destroy(bullet, 2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Debug.Log("Death by Bullet");
        }
    }
}
