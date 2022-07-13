using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InfoButtonForProductBullets : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
    [SerializeField] private Animator animationBuyButton;
    [SerializeField] private Animator animationInfoText;

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        Debug.Log("+");

        animationBuyButton.SetTrigger("DisappearingBuyButtonBullets"); //�������� ������������ ������ ������� ������
        animationInfoText.SetTrigger("AppearanceInfoTextForBullets"); //�������� ��������� ������ � ����������� � ��������
    }
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        Debug.Log("-");

        animationBuyButton.SetTrigger("AppearanceBuyButtonBullets"); //�������� �������� ������ ������� ������
        animationInfoText.SetTrigger("DisappearingInfoTextForBullets"); //�������� ������ � ����������� � ��������
    }
}
