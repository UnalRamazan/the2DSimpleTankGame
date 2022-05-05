using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAINew : MonoBehaviour
{
    public Vector2 position1;
    public Vector2 position2;
    private float oldPosition;

    public float moveSpeed = 5f;
    public float fallowSpeed = 1f;
    public float rocketSpeed = 5f;

    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;

    public GameObject rocketPrefab;
    public GameObject firePoint;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        StartFire();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        EnemyAi();
    }

    void EnemyAi()
    {
        if (TankMove.dead)
        {
            if (Mathf.Abs(player.position.x - this.transform.position.x) < 5 && Mathf.Abs(player.position.y - this.transform.position.y) < 5)
            {
                Vector3 direction = player.position - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                rb.rotation = angle;
                direction.Normalize();
                movement = direction;
                EnemyFallowToPlyer(movement);
            }
            else
            {
                EnemyMove();
            }
        }
    }

    void EnemyFallowToPlyer(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * fallowSpeed * Time.deltaTime));
    }

    void EnemyMove()
    {

        this.transform.position = Vector3.Lerp(position1, position2, Mathf.PingPong(Time.time * moveSpeed, 1.0f));//iki nokta arasýnda hesaplama yapmaya yarýyor

        if (this.transform.position.x > oldPosition)
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, -90);
        }

        if (this.transform.position.x < oldPosition)
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        oldPosition = this.transform.position.x;
    }

    private void StartFire()
    {
        StartCoroutine(Fire());
    }

    IEnumerator Fire()
    {
        //Debug.Log("Düþman tank ateþ etti...");
        GameObject rocket = Instantiate(rocketPrefab, firePoint.transform.position, firePoint.transform.rotation);
        Rigidbody2D rbRocket = rocket.GetComponent<Rigidbody2D>();
        rbRocket.AddForce(firePoint.transform.up * rocketSpeed, ForceMode2D.Impulse);
        Destroy(rocket, 5);

        yield return new WaitForSecondsRealtime(2f);

        StartFire();
    }
}