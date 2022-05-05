using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    public float tankSpeed = 0.005f;
    private float directionOfHorizontalMovement;
    private float directionOfVerticalMovement;
    public static bool dead;
    public static int counter;

    public AudioSource audioSource;

    void Start()
    {
        dead = true;
        counter = 0;
        audioSource.Play();
    }

    void Update()
    {
        directionOfHorizontalMovement = Input.GetAxis("Horizontal");//yatay eksen hareketi için
        directionOfVerticalMovement = Input.GetAxis("Vertical");//dikey eksen hareketi için

        if(directionOfHorizontalMovement != 0 || directionOfVerticalMovement != 0)
        {
            this.transform.up = new Vector3(directionOfHorizontalMovement, directionOfVerticalMovement, 0);//tank yönü için
            this.transform.Translate(new Vector3(directionOfHorizontalMovement, directionOfVerticalMovement, 0) * tankSpeed, Space.World);//tank hareketi için
        }
    }
}