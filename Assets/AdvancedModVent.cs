using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedModVent : MonoBehaviour
{
    [Header("This script was made by @WOW_2832 on yt please give credits if you use this and DO NOT remove this header")]
    [Space]
    [Header("Enjoy")]
    [Space]
    //Variables
    [Header("Put the object here")]
    public GameObject Vent;
    [Header("Hand Tag")]
    public string HandTag;
    [Header("Time")]
    [SerializeField]public float timeUntilEnable = 5f;
    //Enable and disable
    private IEnumerator OnTriggerEnter(Collider other) //s
    {
        if (other.CompareTag(HandTag))
        {
            Vent.SetActive(false); //Enable
            
            yield return new WaitForSeconds(timeUntilEnable);  //Gets time from the variables section
            Vent.SetActive(true);  //Disables
        }
    }
}
