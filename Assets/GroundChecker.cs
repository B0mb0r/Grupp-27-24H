using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public static int JumpCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Våran variabel som kollar om vi är på marken sätts som sann
        JumpCounter = 2;
    }
}
