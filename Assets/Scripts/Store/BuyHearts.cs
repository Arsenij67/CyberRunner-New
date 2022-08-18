using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyHearts : MonoBehaviour
{
    [SerializeField] private Button ButtonBuyHearts;
    [SerializeField] private Coin _coin;

    private const int priceHearts = 1;

    private int quantityHearts;
    public int QuantityHearts { get => quantityHearts; }
    private void Start()
    {
        EventManager.BuyHealth.AddListener(AddHearts);
    }

    private void Update()
    {
        if (_coin.Coins < priceHearts) ButtonBuyHearts.enabled = false;//����� �������� ��� ������� �� ��������� ������ � ������������� �������
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
    }

}
