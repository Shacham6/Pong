using UnityEngine;
using System.Collections;

public class PlayerController : Moving2DGameObject
{
	public float speed;
	Rigidbody2D rb;

	// Use this for initialization
	override public void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	public void Update()
	{

	}

	override public void FixedUpdate()
	{
		float horMov = Input.GetAxis(axisName: "Horizontal");
		Vector3 offset = new Vector2(horMov*(speed/100), 0);
		ApplyVelocity(offset);

	}
}
