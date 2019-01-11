using System.Collections;
using System.Collections.Generic;
using Snake.Scripts;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    private Head head;
    private SnakePart[] parts;

    public GameObject RotatorPrefab;
    public GameObject BodyPartPrefab;
    public float Speed;

    private GameController gameController;
    private bool moveBody = true;

    // Use this for initialization
    void Start()
    {
        head = GetComponentInChildren<Head>();
        parts = GetComponentsInChildren<SnakePart>();
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        MoveSnake();
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RotateLeft();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            RotateRight();
        }
    }

    private void MoveSnake()
    {
        if (moveBody)
        {
            foreach (var part in parts)
            {
                part.Move(Speed);
            }
        }
        else
        {
            foreach (var part in parts)
            {
                part.Move(0);
            }
            head.Move(Speed);
        }
    }

    private void RotateRight()
    {
        CreateRotator(90.0f);
    }

    private void RotateLeft()
    {
        CreateRotator(-90.0f);
    }

    private void CreateRotator(float angle)
    {
        var rotator = Instantiate(RotatorPrefab);
        rotator.transform.position = head.transform.position;
        rotator.GetComponent<SnakeRotator>().Angle = angle;
    }

    public void Grow()
    {
        gameController.Score+= parts.Length-2;
        var bodyPart = Instantiate(BodyPartPrefab,transform);
        bodyPart.transform.position = head.transform.position;
        bodyPart.transform.rotation = head.transform.rotation;
        parts = GetComponentsInChildren<SnakePart>();
        var newSnakePart =bodyPart.GetComponent<SnakePart>();
        newSnakePart.Enabled = false;
        moveBody = false;
        StartCoroutine(DelayBody(newSnakePart));
    }

    private IEnumerator DelayBody(SnakePart snakePart)
    {
        yield return new WaitForSecondsRealtime((0.35f * 200)/Speed);
        moveBody = true;
        snakePart.Enabled = true;
    }
}