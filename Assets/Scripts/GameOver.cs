using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private MeterCounter _meterCounter;
    [SerializeField] private Coin _coin;

    [SerializeField] private Text scoreMeter;
    
   

    private void Update()
    {
      

        scoreMeter.text = _meterCounter.MeterCount + " m";
       
    }
   
   

}
