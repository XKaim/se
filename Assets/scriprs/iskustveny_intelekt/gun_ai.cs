using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_ai : MonoBehaviour
{
	public static float speed = 30; // скорость пули
	public Rigidbody2D bullet; // префаб нашей пули
	public Transform gunPoint; // точка рождения
	public float fireRate = 1; // скорострельность
	public float curTimeout;
	public static bool a = false;


	void Fire1()
	{
		curTimeout += Time.deltaTime;
		if (curTimeout > fireRate)
		{
			curTimeout = 0;
			Rigidbody2D clone = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody2D;
			clone.velocity = transform.TransformDirection(gunPoint.up * speed);
			clone.transform.right = gunPoint.right;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
			a = true;
		}
    }

    void Update()
    {
		if(a == true)
        {
			Fire1();
		}
    }
}
