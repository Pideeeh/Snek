using Snake.Scripts;
using UnityEngine;

//Marker class for Head of snake
public class Head : SnakePart
{
    //Restarts game whenever snake collides with itself
    private void OnTriggerEnter(Collider other)
    {
        var bodyPart = other.GetComponent<SnakePart>();
        if (bodyPart != null && !bodyPart.First)
        {
            FindObjectOfType<GameController>().RestartGame();
        }
    }
}