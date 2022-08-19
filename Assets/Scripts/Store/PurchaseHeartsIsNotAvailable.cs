using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseHeartsIsNotAvailable : MonoBehaviour
{
    private BuyHearts buyHearts;
    private Text text;

    private void Start()
    {
        buyHearts = transform.parent.parent.GetComponent<BuyHearts>();
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = "��� ������� �� ������� " + buyHearts.NumberOfMissingCoins + " �����.";
    }
}
