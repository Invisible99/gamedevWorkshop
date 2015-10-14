using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour
{
	public float Speed;
	public float Gravity;

	CharacterController motor;
	// Use this for initialization
	void Start()
	{
	motor = GetComponent<CharacterController>() as CharacterController;
	}

	// Update is called once per frame
	void Update()
	{

		var direction = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Jump"), Input.GetAxis("Vertical"));

		motor.Move(new Vector3(direction.x * Speed * Time.deltaTime, direction.y * Speed * Time.deltaTime, direction.z * Speed * Time.deltaTime));

		/*if (direction != Vector3.zero)
		{
			this.transform.position += new Vector3(direction.x * Speed * Time.deltaTime, direction.y*Speed*Time.deltaTime, direction.z * Speed * Time.deltaTime);
		}*/
	}
}
