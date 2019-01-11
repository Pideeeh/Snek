using UnityEngine;

namespace Snake.Scripts
{
    //Marker class for each part of the snake with logic for moving into current direction. 
    [RequireComponent(typeof(Rigidbody))]
    public class SnakePart : MonoBehaviour
    {
        //Flag required to prevent collision when snake is turning.
        public bool First;
        private Rigidbody rigidbody;
        
        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
        }
        
        public void Move(float speed)
        {
            rigidbody.velocity = transform.forward * speed * Time.deltaTime;
        }
    }
}