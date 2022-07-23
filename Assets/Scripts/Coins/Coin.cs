using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private int quantityCoins;//����������, ������� �������� �� ���������� ����� � ������
    public int Coins { get => quantityCoins; }

    private void Start()
    {
        EventManager.PickUpCoinEvent.AddListener(AddingCoin);
    }

    private void AddingCoin()
    { 
        quantityCoins++;
    }

}
