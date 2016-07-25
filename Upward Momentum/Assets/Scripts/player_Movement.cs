using UnityEngine;
using System.Collections;

public class player_Movement : MonoBehaviour {

	public int playerSpeed;
	public int jumpHeight;

	public Transform groundPoint;
	public float radius;
	public LayerMask groundMask;

	bool isGrounded;
	Rigidbody2D rb2D;

	// Use this for initialization
	void Start () 
	{
		rb2D = GetComponent<Rigidbody2D>();

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 moveDirection = new Vector2 (Input.GetAxis("Horizontal") * playerSpeed, rb2D.velocity.y);
		rb2D.velocity = moveDirection;

		isGrounded = Physics2D.OverlapCircle(groundPoint.position, radius, groundMask);

		if(Input.GetAxis("Horizontal") == 1)
		{
			transform.localScale = new Vector3 (3, 3, 3);
		}
		else if (Input.GetAxis("Horizontal") == -1)
		{
			transform.localScale = new Vector3 (-3, 3, 3);
		}

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb2D.AddForce (new Vector2 (0, jumpHeight));
		}
	}

		void OnDrawGizmos ()
		{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(groundPoint.position, radius);
		}
	
}
