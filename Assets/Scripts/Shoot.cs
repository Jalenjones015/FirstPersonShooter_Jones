using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform point;
    public GameObject bulletpre;
    public GameObject dio;
    public ParticleSystem particle;
    public float bullforce = 5f;
    public float betweenshots = .5f;
    private float tim = 0f;
    public float reloading = 1f;
    public int mammo = 10;
    private int currammo;
    public Animator animator;
    public bool isreloading;

    private void Start()
    {
        currammo = mammo;
    }

    void Update()
    {
        if (isreloading)
            return;

        if (currammo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if ((Input.GetButton("Fire1") && (Time.time >= tim)))
        {
            shoot();
            tim = Time.time + betweenshots;
            dio.GetComponent<AudioSource>().Play();
            particle.GetComponent<ParticleSystem>().Play();
        }
    }

    IEnumerator Reload()
    {
        isreloading = true;
        Debug.Log("Relodaing");
        animator.SetBool("reload", true);
        yield return new WaitForSeconds(reloading - 1f);
        animator.SetBool("reload", false);
        yield return new WaitForSeconds(2.7f);
        currammo = mammo;
        isreloading = false;

    }

    public void shoot()
    {
        GameObject bullet = Instantiate(bulletpre, point.position, point.rotation);
        Rigidbody rigid = bullet.GetComponent<Rigidbody>();
        rigid.AddForce(point.up * bullforce, ForceMode.Impulse);
        Destroy(bullet, 2f);
        currammo--;
    }
}
