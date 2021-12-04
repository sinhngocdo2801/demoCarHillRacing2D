using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

	public float speed = 0f;
	public float rotationSpeed = 15f;

    public static float heart = 1f;
	public float heartConsumpion = 0.1f;

	[SerializeField]
    private Image heartIamge;


	private float maxSpeed = 3000f;
    public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;

	public Rigidbody2D rb;

	private float movement = 0f;
	private float rotation = 0f;

    private void Awake()
    {
		
		heart = 1f;
    }

    void Update ()
	{
        #region Move With velocity time by time
        //// higher movespeed with w and up key
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            if (speed <= maxSpeed)
                speed += 10;
            else
                speed = maxSpeed;
        }
        #endregion
        //movement input
        movement = -Input.GetAxisRaw("Vertical") * speed;
		rotation = Input.GetAxisRaw("Horizontal");

        #region move with button
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
        #endregion

        heartIamge.fillAmount = heart;

    }//Update







    void FixedUpdate ()
	{
        #region move with joinMotor2D
		if( heart > 0)
        {
			if (movement == 0f)
			{
				backWheel.useMotor = false;
				frontWheel.useMotor = false;
			}
			else
			{
				backWheel.useMotor = true;
				frontWheel.useMotor = true;

				JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 100 };
				backWheel.motor = motor;
				frontWheel.motor = motor;

				
			}
			rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
		}
		//else
  //      {
		//	EndGame.ins.GameOver();
  //      }

		// filldown in heart
		heart -= heartConsumpion * Time.fixedDeltaTime;

		#endregion

		#region move with Addtouque rigidbody2d on wheel

		//if (heart > 0)
		//      {
		//	backWheel.AddTorque(movement * Time.fixedDeltaTime);
		//	frontWheel.AddTorque(movement * Time.fixedDeltaTime);
		//	rb.AddTorque(movement * CarTouge * Time.fixedDeltaTime);
		//}

		//heart -= heartConsumpion * Time.fixedDeltaTime;
		#endregion

	}//fixedUpdate

}
