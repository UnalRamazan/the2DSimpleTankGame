using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterLifeTime : MonoBehaviour
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
            TankMove.dead = false;
            Destroy(this.gameObject);
            Debug.Log("Oyuncu yok oldu.");
        }
    }
}