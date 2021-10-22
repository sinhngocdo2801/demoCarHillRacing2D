using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public float speed = 1500f;
	public float rotationSpeed = 15f;

	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;

	public Rigidbody2D rb;

	private float movement = 0f;
	private float rotation = 0f;

	void Update ()
	{

        movement = -Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxisRaw("Horizontal");

  //      //set movement value
  //      if (CarMoveController.isUpButtonDown = true)
  //      {
		//	movement = 1f * speed;
  //      }
		//else if(CarMoveController.isDownButtonDown = true)
  //      {
		//	movement = -1f * speed;
  //      }
		//else
  //      {
		//	movement = 0f;
  //      }

		////set rotation value
		//if (CarMoveController.isRightButtonDown = true)
		//{
		//	rotation = 1f;
		//}
		//else if (CarMoveController.isLeftButtonDown = true)
  //      {
		//	rotation = -1f;
  //      }
		//else
  //      {
		//	rotation = 0f;
  //      }
		


	}

	void FixedUpdate ()
	{
		if (movement == 0f)
		{
			backWheel.useMotor = false;
			frontWheel.useMotor = false;
		} else
		{
			backWheel.useMotor = true;
			frontWheel.useMotor = true;

			JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
			backWheel.motor = motor;
			frontWheel.motor = motor;

			rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
		}

		
    }

}
