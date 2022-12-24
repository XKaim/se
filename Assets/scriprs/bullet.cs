using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class bullet : MonoBehaviour
{

	void Start()
	{
		// уничтожить объект по истечению указанного времени (секунд), если пуля никуда не попала
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