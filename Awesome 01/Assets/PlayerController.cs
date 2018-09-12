using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour 

{
	public float speed = 800.0f;
	public Camera c;

	void FixedUpdate() 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		movement = c.transform.TransformDirection(movement);
		GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);


	}


	void Update()
	{
		if(Input.GetKeyDown("space")){
			Vector3 movement = new Vector3 (0.0f, 0.0f,1);
			GetComponent<Rigidbody>().AddForce(movement * 800 *Time.deltaTime);
		}

	}




}


//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;
//public class PlayerController : MonoBehaviour 
//{
//	public float walkSpeed;
//
//	Rigidbody rb;
//	Vector3 moveDirection;
//
//	void Awake()
//	{ 
//		rb = GetComponent<Rigidbody>();
//	}
//
//	void Update()
//	{
//		float horizontalMovement = Input.GetAxis ("Horizontal");
//		float verticalMovement  = Input.GetAxis ("Vertical");
//		moveDirection = (horizontalMovement * transform.right + verticalMovement * transform.forward).normalized;
//	}
//
//	void FixedUpdate()
//	{
//		Move();
//	}
//
//	void Move()
//	{
//		Vector3 yvelFix = new Vector3(0, rb.velocity.y, 0);
//		rb.velocity = moveDirection * walkSpeed * Time.deltaTime;
//		rb.velocity += yvelFix;
//	}
//
//
//	//	public float speed = 1600.0f;
////	public Camera c;
////	public Text scoreText;
////	private int count = 0;
////	public Text winText;
////	void FixedUpdate() 
////	{
////		float moveHorizontal = Input.GetAxis ("Horizontal");
////		float moveVertical = Input.GetAxis ("Vertical");
////		
////		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
////		movement = c.transform.TransformDirection(movement);
////		GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
////
////		
////	}
////
////	void Update()
////	{
////		if(Input.GetKeyDown("space")){
////			Vector3 movement = new Vector3 (0.0f, 0.0f,1);
////			GetComponent<Rigidbody>().AddForce(movement * 800 *Time.deltaTime);
////		}
////		
////	}
//
//
//
//
//}
