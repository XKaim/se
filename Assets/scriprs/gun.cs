using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour
{

	public float speed = 10; // скорость пули
	public Rigidbody2D bullet; // префаб нашей пули
	public Transform gunPoint; // точка рождения
	public float fireRate = 1; // скорострельность
	public static int amm = 12;
	bool j = false;
	public Transform zRotate; // объект для вращения по оси Z
	private float time = 2;
	// ограничение вращения
	public float minAngle = -40;
	public float maxAngle = 40;
	bool d = false;
	private float curTimeout;

	void Start()
	{
		amm = 12;
	}

	void SetRotation()
	{
		Vector3 mousePosMain = Input.mousePosition;
		mousePosMain.z = Camera.main.transform.position.z;
		Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePosMain);
		lookPos = lookPos - transform.position;
		float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
		angle = Mathf.Clamp(angle, minAngle, maxAngle);
		zRotate.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}

	void Update()
	{
		
		if (Input.GetMouseButtonDown(0) && amm>0 && time == 2 && glavnoe_menu.c == false)
		{
			amm--;
			Fire();
		}
		else
		{
			curTimeout = 100;
		}

		if (zRotate) SetRotation();
		if (j == true)
		{
			time = time - Time.deltaTime;
			if (time < 0)
			{
				d = true;
				time = 2;
				j = false;
			}
		}
		
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			j = true;
			
			
		}
		if (d == true)
		{
			amm = 12;
			d = false;
		}
	}

	void Fire()
	{
		curTimeout += Time.deltaTime;
		if (curTimeout > fireRate)
		{
			curTimeout = 0;
			Rigidbody2D clone = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody2D;
			clone.velocity = transform.TransformDirection(gunPoint.right * speed);
			clone.transform.right = gunPoint.right;
		}
	}

	void Timee()
    {
		
		
		
	}
}
