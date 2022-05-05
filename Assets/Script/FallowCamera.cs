using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallowCamera : MonoBehaviour
{
    public Transform positionOfTank;//tank bulunduðu konum
    Vector3 distance;

    void Start()
    {
        distance = transform.position - positionOfTank.position;//bulundugumuz konumdan tank konumunu çýkartacaðýz (tank ile aramýzdaki mesafeyi öðrendik)
    }


    void Update()
    {
        if (TankMove.dead)
        {
            transform.position = positionOfTank.position + distance;//tank göre posizyonumuzu deðiþtirdik
        }
        else
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("GameOver");
        }

        if(TankMove.counter == 4)//oyun bittiði zaman
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("VictoryMenu");
        }
    }
}