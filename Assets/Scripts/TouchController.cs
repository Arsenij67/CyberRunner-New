using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchController : MonoBehaviour, IBeginDragHandler, IDragHandler
{
	[SerializeField] private GameObject Player;
	private Rigidbody PlayerRb;
	[SerializeField] private float JumpHeight=60; //������ ������
	private RaycastHit hit;
	[SerializeField] private Animator anim;
	void Awake()
	{
		 
	}
	public void OnBeginDrag(PointerEventData eventData) // ����������� ����� ����� �������� ������������
	{
		if (eventData.delta.y > 0 && hit.distance < 1)
		{


			anim.SetTrigger("Jump");

			PlayerRb = Player?.GetComponent<Rigidbody>();


			PlayerRb.velocity = Vector3.up * Time.deltaTime * 8000;// ������� ���� ����� ��������� ����� ��������� �����



		}

		else if (eventData.delta.y < 0 && hit.distance < 1)
		{

			anim.SetTrigger("Scroll");


		}

		 
	}
	void FixedUpdate()
	{
		Physics.Raycast(Player.transform.position, Vector3.down, out hit); //������� ��� ��� ��������

		if ((hit.distance > JumpHeight&&(hit.transform.tag.Equals("Road") || hit.transform.tag.Equals("Obstacle"))) ) // ���� �� �������� ���� ������
																													  // ������ � ��� ���� ������ ��� ����������� - ����� ������
		{
			print("������");
			PlayerRb.velocity = Vector3.zero;
			PlayerRb.velocity += Vector3.down * Time.deltaTime * 4000;
			PlayerRb.velocity += Vector3.forward * Time.deltaTime * 2000;
		 
		
		}
	
	
	}
	public void OnDrag(PointerEventData eventData)
	{
		print("");
	}
}
