using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public int numberOfPoints;
    public float speed;
    public bool forward;
    private Vector3[] points;
    private int count;

    void Start()
    {
        points = new Vector3[numberOfPoints];
        ArrayFilling();
        count = 0;
        transform.LookAt(points[count]);
    }

    void Update()
    {
        transform.Rotate(0, 0, 1);
        if (forward)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[count], speed * Time.deltaTime);
        }
        if (transform.position == points[count] && count < numberOfPoints - 1)
        {
            count++;
            transform.LookAt(points[count]);
        }
        else if (transform.position == points[count] && count == numberOfPoints - 1)
        {
            forward = false;
        }
    }

    private void ArrayFilling()
    {
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = new Vector3(Random.Range(-10f,10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        }
    }
}
