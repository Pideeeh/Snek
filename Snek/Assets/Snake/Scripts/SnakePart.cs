using UnityEngine;

namespace Snake.Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class SnakePart : MonoBehaviour
    {
        private Rigidbody rigidbody;
        //Used to delay collision on new Body Parts
        public bool Enabled { get; set; }
        
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