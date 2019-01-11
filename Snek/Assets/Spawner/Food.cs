using System.Collections;
using System.Collections.Generic;
using Snake.Scripts;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Food : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        var head = other.GetComponent<Head>();
        if (head != null)
        {
            var snake = FindObjectOfType<SnakeController>();
            if (snake != null)
            {
                snake.Grow();
            }
            
            
            
            Destroy(gameObject);
        }
        
    }
}
