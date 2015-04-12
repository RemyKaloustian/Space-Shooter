using UnityEngine;
using System.Collections;
[System.Serializable] 
public class Boundary
{
	public float xMin, xMax, zMin, zMax;

}//class Boundary

public class PlayerController : MonoBehaviour
{
	public float m_speed;
	public float tilt;
	public Boundary m_boundary;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;

	void Update()
	{//Input.GetButton ("Fire1")
		if (Input.GetKeyDown ("space") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			audio.Play();
		}

	}

	void FixedUpdate()
	{	
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.velocity = movement * m_speed;
		rigidbody.position = new Vector3
			(
				Mathf.Clamp(rigidbody.position.x, m_boundary.xMin, m_boundary.xMax),
				0.0f,
				Mathf.Clamp(rigidbody.position.z, m_boundary.zMin, m_boundary.zMax) 
			);

		rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);
	}//FixedUpdate()

}//class PlayerController
