using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvertistGoing : MonoBehaviour
{
    private float ValueNow = 1;
    private Slider Slider;
    private static Button ButtonAds;
	private ushort QuantityWieves = 0;
	
	public IEnumerator  IncreaseSlider()
    {
        if (QuantityWieves < 1)
        {
            EventManager.ButtonClicked.Invoke();
            Slider = gameObject.GetComponent<Slider>();//�������� 
            ButtonAds = GameObject.Find("Advertis_Button").GetComponent<Button>();

            while (ValueNow > -0.05)
            {

                Slider.value = ValueNow;
                ValueNow -= 0.1f * Time.deltaTime;
                yield return new WaitForEndOfFrame();


            }
            ButtonAds.interactable = false;

            QuantityWieves++;

            StopCoroutine(IncreaseSlider());


             

        }
    
    }
    
}
