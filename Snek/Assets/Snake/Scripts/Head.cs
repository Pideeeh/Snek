using Snake.Scripts;
using UnityEngine;

public class Head : SnakePart
{
    private void OnTriggerEnter(Collider other)
    {
        var bodyPart = other.GetComponent<SnakePart>();
        if (bodyPart != null && !bodyPart.First)
        {
            FindObjectOfType<GameController>().RestartGame();
        }
    }
}