using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jump = 2.5f;
 
    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока
        Jump player = other.GetComponent<Jump>();
        if (player){
            player.jumpStrength *= jump;
        }
    }
 
    void OnTriggerExit(Collider other)
    {
        //Понижение скорости бега игрока
        Jump player = other.GetComponent<Jump>();
        if (player){
            player.jumpStrength /= jump;
        }
    }
}
