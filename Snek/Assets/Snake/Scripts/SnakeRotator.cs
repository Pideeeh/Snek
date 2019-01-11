using Snake.Scripts;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SnakeRotator : MonoBehaviour
{
    public float Angle;

    private Vector3 headPosition;
    private bool first = true;

    private void OnTriggerExit(Collider other)
    {
        var part = other.GetComponent<SnakePart>();
        if (part)
        {
            if (first)
            {
                headPosition = part.transform.position;
                first = false;
            }
            else
            {
                part.transform.position = headPosition;
            }

            part.transform.Rotate(0, Angle, 0);
        }

        var tail = other.GetComponent<Tail>();
        if (tail)
        {
            Destroy(gameObject);
        }
    }
}