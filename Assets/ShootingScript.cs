using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour 
{

	public Rigidbody projectile;
	public float speed = 5f;
	
	void ShootFireball () 
	{
		Rigidbody clone = (Rigidbody) Instantiate(projectile, transform.position, transform.rotation);
		clone.velocity = transform.forward * speed;
		
		Destroy(clone.gameObject,3.0f);
	}
	
	// Calls the fire method when holding down ctrl or mouse
	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.Q))
			ShootFireball();
	}
}
