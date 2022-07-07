using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonController :MonoBehaviour
{
   public float GameSpeed;
    public GameObject Main_Menu_Condition; // ������ �� ������� ����
    public GameObject Settings_Menu;

	private void Start()
	{
        Settings_Menu.SetActive(false);
	}
	public void InputPlay() /* ����� ��� ������������� �������� ����������� ������� ������ 
                              (��� ������� �� ������ Play � ������� ����)*/
    {
        Main_Menu_Condition.SetActive(false);
        EventManager.EventPlay?.Invoke(GameSpeed);
    }

    public void InputSettings()
    {
        Main_Menu_Condition.SetActive(false);
        Settings_Menu.SetActive(true);
    
    
    }

    
}
