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
			var pos = part.transform.position;
			if (pos.x > 40)
			{
				pos.x -= 80;
			}
			else if (pos.x < -40)
			{
				pos.x += 80;
			}
			else if (pos.z > 40)
			{
				pos.z -= 80;
			}
			else if (pos.z < -40)
			{
				pos.z += 80;
			}

			part.transform.position = pos;
		}
	}
}
