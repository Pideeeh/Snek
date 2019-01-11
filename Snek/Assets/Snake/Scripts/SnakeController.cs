using System.Collections;
using System.Collections.Generic;
using Snake.Scripts;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
	private Head head;
	private SnakePart[] parts;

	public GameObject RotatorPrefab;
	public GameObject BodyPartPrefab;
	public float Speed;

	// Use this for initialization
	void Start ()
	{
		parts = GetComponentsInChildren<SnakePart>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		CheckInput();
		MoveSnake();

	}

	void CheckInput()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			RotateLeft();
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			RotateRight();
		}


	}

	private void MoveSnake()
	{
		foreach (var part in parts)
		{
			part.Move(Speed);
		}
	}

	private void RotateRight()
	{
		CreateRotator(-90.0f);
	}

	private void RotateLeft()
	{
		CreateRotator(90.0f);
	}

	private void CreateRotator(float angle)
	{
		Instantiate(RotatorPrefab);
		RotatorPrefab.transform.position = head.transform.position;
		var rotator = RotatorPrefab.GetComponent<SnakeRotator>();
		if (rotator)
		{
			rotator.Angle = angle;
		}
	}
}