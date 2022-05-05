using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
      
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Character")
        {
            collision.gameObject.GetComponent<CharacterLifeTime>().takeDamage();
            Debug.Log("Oyuncu Hasar Aldý");
            Destroy(this.gameObject);
        }

        if(collision.tag == "Enemy" && this.gameObject.tag != "EnemyRocket")
        {
            collision.gameObject.GetComponent<EnemyLifeTime>().takeDamage();
            //Debug.Log("Düþamn Tank Hasar Aldý");
            Destroy(this.gameObject);
            TankMove.counter++;
        }

        if(collision.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }

        if(collision.tag == "ObstacleForDamage")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}