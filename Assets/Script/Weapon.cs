using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float rocketSpeed = 5f;
    public GameObject rocketPrefab1;
    public GameObject rocketPrefab2;
    public GameObject firePoint1;
    public GameObject firePoint2;

    public AudioSource audioSource;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    public void Fire()
    {
        GameObject rocket1 = Instantiate(rocketPrefab1, firePoint1.transform.position, this.transform.rotation);
        Rigidbody2D rb1 = rocket1.GetComponent<Rigidbody2D>();
        rb1.AddForce(firePoint1.transform.up * rocketSpeed, ForceMode2D.Impulse);
        audioSource.Play();
        Destroy(rocket1, 5);

        GameObject rocket2 = Instantiate(rocketPrefab2, firePoint2.transform.position, this.transform.rotation);
        Rigidbody2D rb2 = rocket2.GetComponent<Rigidbody2D>();
        rb2.AddForce(firePoint2.transform.up * rocketSpeed, ForceMode2D.Impulse);
        audioSource.Play();
        Destroy(rocket2, 5);
    }
}