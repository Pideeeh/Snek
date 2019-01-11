using System.Collections;
using System.Collections.Generic;
using Snake.Scripts;
using UnityEngine;

//Manager for moving snake parts when they leave the play area (Collider of Map)
public class MapManager : MonoBehaviour {

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
