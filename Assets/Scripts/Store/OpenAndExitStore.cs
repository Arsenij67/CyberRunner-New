using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndExitStore : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject store;

    public void OpenShop()
    {
        EventManager.ButtonClicked.Invoke();// �������� ���� ������� 
        mainMenu.SetActive(false);
        store.SetActive(true);

        Debug.Log("TransferQuantityCoin.transferQuantityCoin: " + TransferQuantityCoin.transferQuantityCoin);
    }

    public virtual void ExitMenu() // ������ ��������� ��� ��������������� � ������ ButtonController.
    {
        EventManager.ButtonClicked.Invoke();// �������� ���� ������� 
        mainMenu.SetActive(true);
        store.SetActive(false);
    }

    
}
