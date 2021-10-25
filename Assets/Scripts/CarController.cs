using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public float speed = 0f;
	public float rotationSpeed = 15f;
	private float maxSpeed = 3000f ;
	private float minSpeed = 0f;

	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;

	public Rigidbody2D rb;

	private float movement = 0f;
	private float rotation = 0f;

	void Update ()
	{

        movement = -Input.GetAxisRaw("Vertical");
        rotation = Input.GetAxisRaw("Horizontal");

		// higher movespeed with w and up key
		if (Input.GetKey("w") || Input.GetKey("up"))
		{
			if (speed <= maxSpeed)
				speed += 30;
			else
				speed = maxSpeed;
		}
		// lower movespeed with s and down key
		else if (Input.GetKey("s") || Input.GetKey("down"))
		{
			if (speed >= minSpeed)
				speed -= 30;
		}
		// lower movespeed if no key is pressed
		else if (!Input.GetKey("w") || !Input.GetKey("up"))
		{
			if (speed >= 0)
				speed -= 30;
		}

		/*
        //set movement value
        if (CarMoveController.isUpButtonDown = true)
        {
			movement = 1f * speed;
        }
		else if(CarMoveController.isDownButtonDown = true)
        {
			movement = -1f * speed;
        }
		else
        {
			movement = 0f;
        }

		//set rotation value
		if (CarMoveController.isRightButtonDown = true)
		{
			rotation = 1f;
		}
		else if (CarMoveController.isLeftButtonDown = true)
        {
			rotation = -1f;
        }
		else
        {
			rotation = 0f;
        }
		*/



	}//Update

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

			JointMotor2D motor = new JointMotor2D { motorSpeed = movement * speed, maxMotorTorque = 10000 };
			backWheel.motor = motor;
			frontWheel.motor = motor;

			rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
		}

		
    }//fixedUpdate

}
