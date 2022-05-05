using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeTime : MonoBehaviour
{
    public int lifeTime = 100;
    public int damageValue = 100;

    void Start()
    {

    }


    void Update()
    {

    }

    public void takeDamage()
    {
        lifeTime -= damageValue;

        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Düþman tank yok edildi.");
        }

    }
}