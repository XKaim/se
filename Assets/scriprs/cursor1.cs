using UnityEngine;
using System.Collections;
 
public class cursor1 : MonoBehaviour
{
    void Update()
    {
        var mousePosition = Input.mousePosition;
        //mousePosition.z = transform.position.z - Camera.main.transform.position.z; // ��� ������ ��� ������������� ������ ����������
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //��������� ���� �� �������� � ������� ����������
        var angle = Vector2.Angle(Vector2.right, mousePosition - transform.position);//���� ����� �������� �� ������� � ���� � ���� �
        transform.eulerAngles = new Vector3(0f, 0f, transform.position.y < mousePosition.y ? angle : -angle);//������� ����� �� ��������
    }
}