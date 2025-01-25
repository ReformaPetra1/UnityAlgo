using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float Jumpfactor = 6.5f;
    
    void OnTriggerEnter(Collider other)
    {
        //увеличени высоты прыжка игрока
        other.GetComponent<Jump>().jumpStrength *= Jumpfactor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = Jumpfactor;
    }
}
