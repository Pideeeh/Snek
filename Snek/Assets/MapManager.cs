using System.Collections;
using System.Collections.Generic;
using Snake.Scripts;
using UnityEngine;

public class MapManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerExit(Collider other)
	{
		var part = other.GetComponent<SnakePart>();
		if (part != null)
		{
			if (part.transform.position.x > 40)
			{
				part.transform.Translate(-80,0,0);
			}
			if (part.transform.position.x < -40)
			{
				part.transform.Translate(80,0,0);
			}
			if (part.transform.position.z > 40)
			{
				part.transform.Translate(0,0,-80);
			}
			if (part.transform.position.z < -40)
			{
				part.transform.Translate(0,0,80);
			}
		}
	}
}
