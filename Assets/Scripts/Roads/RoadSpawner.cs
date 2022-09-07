using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoadSpawner : MonoBehaviour
{
    public List<GameObject> roads;//������ ������ �����
    public Player PlayerCoord;
   [SerializeField] private float offset = 1000f;//����������, ������� �������� �� �������� ����� ����������� ������ �� ��� Z
    private int num = 0;
    private int NumRoad
    #region    

    {
        get
        {
            NumRoad = num;
            return num; 
        
        } 
        set

        {

            if (value == 1)num = 0;
            
            else if (value == 0) num = 1;
       }


    }
    #endregion  
private void Start()
    {
        if (roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(r => r.transform.position.z).ToList(); //��������� ������ ��� ����, ����� � �� ���������� ��� ������� ���������, ������� �� ��������� ����������
        }
    }

    public void MoveRoad()
    {
         

        print("����� ������ ������ �������� " + NumRoad);

        GameObject NewRoad; 
        //������ ��������� ���������� � ������� �������� ������ ������� �� ������, �.�. �� ������, ������� ����� ����� ���������� (������ FirstRoad(1))
        NewRoad = roads[NumRoad];
      
        float newZ = PlayerCoord.transform.position.z + offset;  //��������� ����� ���������� Z �� ������ ��������� ���������� �������� �� ��� Z � �������� (���������� offset)

      Instantiate(NewRoad, new Vector3(0, 0, newZ), Quaternion.identity);

        if (NumRoad.Equals(1))
            Destroy(NewRoad);
         


       





    }

}
