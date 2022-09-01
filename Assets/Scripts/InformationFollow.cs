using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationFollow:CameraFollow
{ 

    public float DistanceY;
    public Text Name;
	void Start()
    {
        Name.text = PlayerPrefs.GetString("Name");
        gameObject.SetActive(true);
        

    }
   
   
   
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 EndPoin = new Vector3(Player.transform.position.x,Player.transform.position.y+ DistanceY, Player.transform.position.z);

        transform.position = Vector3.Lerp(transform.position,EndPoin,10f*Time.deltaTime);
        
    }

   
   
}
