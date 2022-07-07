using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndExitStore : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject store;

    public void OpenShop()
    {
        mainMenu.SetActive(false);
        store.SetActive(true);
    }

    public virtual void ExitMenu() // ������ ��������� ��� ��������������� � ������ ButtonController.
    {
        mainMenu.SetActive(true);
        store.SetActive(false);
    }

    
}
