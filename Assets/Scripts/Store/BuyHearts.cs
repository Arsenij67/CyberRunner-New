using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyHearts : MonoBehaviour
{
    [SerializeField] private Text textTheUnavailabilityPurchaseHearts;
    [SerializeField] private Button ButtonBuyHearts;
    [SerializeField] private Coin _coin;


    private const int priceHearts = 100; //100

    private int quantityHearts;
    public int QuantityHearts { get => quantityHearts; }

    private int numberOfMissingCoins;//����������, ������� �������� �� ���������� ����������� ����� ��� ������� ������
    public int NumberOfMissingCoins { get => numberOfMissingCoins; }
    private void Start()
    {
        EventManager.BuyHealth.AddListener(AddHearts);
        numberOfMissingCoins = priceHearts - _coin.Coins;
    }

    private void Update()
    {
        if (_coin.Coins < priceHearts)
        {
            //ButtonBuyHearts.enabled = false;//����� �������� ��� ������� �� ��������� ������ � ������������� �������
            ButtonBuyHearts.gameObject.SetActive(false);
            textTheUnavailabilityPurchaseHearts.gameObject.SetActive(true);
        }
        
    }

    public void Buy()
    {
        if (EventManager.BuyHealth != null)
        {
            EventManager.ButtonClicked.Invoke();// �������� ���� ������� 
            EventManager.BuyHealth.Invoke();
        }
    }

    public void AddHearts()
    {
        quantityHearts++;
        _coin.Coins -= priceHearts;
    }

}
