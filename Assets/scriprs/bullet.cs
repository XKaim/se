using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class bullet : MonoBehaviour
{

	void Start()
	{
		// ���������� ������ �� ��������� ���������� ������� (������), ���� ���� ������ �� ������
		Destroy(gameObject, 60);


	

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag != "qwe")
        {
			Destroy(gameObject);
		}
	}
}