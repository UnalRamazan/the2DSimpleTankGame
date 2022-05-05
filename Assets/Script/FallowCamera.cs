using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallowCamera : MonoBehaviour
{
    public Transform positionOfTank;//tank bulundu�u konum
    Vector3 distance;

    void Start()
    {
        distance = transform.position - positionOfTank.position;//bulundugumuz konumdan tank konumunu ��kartaca��z (tank ile aram�zdaki mesafeyi ��rendik)
    }


    void Update()
    {
        if (TankMove.dead)
        {
            transform.position = positionOfTank.position + distance;//tank g�re posizyonumuzu de�i�tirdik
        }
        else
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("GameOver");
        }

        if(TankMove.counter == 4)//oyun bitti�i zaman
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("VictoryMenu");
        }
    }
}