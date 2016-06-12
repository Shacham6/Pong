using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class Moving2DGameObject : MonoBehaviour
{
	public float acceleration;
	public abstract void Start();
	public abstract void FixedUpdate();

	public void ApplyVelocity(Vector2 velocity)
	{
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		do
		{
			rb.AddRelativeForce(velocity.normalized * acceleration);
		} while (velocity != rb.velocity);
	}
}
