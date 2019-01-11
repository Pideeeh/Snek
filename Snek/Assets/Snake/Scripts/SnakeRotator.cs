using Snake.Scripts;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SnakeRotator : MonoBehaviour
{
    public float Angle;

    private void OnTriggerExit(Collider other)
    {
        var part = other.GetComponent<SnakePart>();
        if (part)
        {
            part.transform.Rotate(0,Angle,0);
        }

        var tail = other.GetComponent<Tail>();
        if (tail)
        {
            Destroy(gameObject);
        }
    }
}