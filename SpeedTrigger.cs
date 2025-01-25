using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 50f;

    void OnTriggerEnter(Collider other)
    {
        //увеличение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        
    }

    
    void pnTriggerenter(Collider other)
    {
        //понижение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;

    }
}
