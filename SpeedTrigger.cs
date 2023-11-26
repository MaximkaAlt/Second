using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speed = 2.5f;
 
    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока
        FirstPersonMovement player = other.GetComponent<FirstPersonMovement>();
        if (player){
            player.runSpeed *= speed;
        }
    }
 
    void OnTriggerExit(Collider other)
    {
        //Понижение скорости бега игрока
        FirstPersonMovement player = other.GetComponent<FirstPersonMovement>();
        if (player){
            player.runSpeed /= speed;
        }
    }

}
