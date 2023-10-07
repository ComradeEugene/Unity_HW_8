using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private int numberOfPoints;
	[SerializeField] private float speed;

	private bool forward;
    private Vector3[] points;
    private Vector3 currentTargey;
    private int count;

    void Start()
    {
        count = -1;
	}

    void Update()
    {
        if (count >= 0)
        {
            Look();
            transform.position = Vector3.MoveTowards(transform.position, points[count], speed * Time.deltaTime);
            CalculationOfTarget();
        }
    }

    private void ArrayFilling()
    {
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = new Vector3(Random.Range(-300f,300f), Random.Range(-300f, 300f), 0);
        }
    }

    private void Look()
    {
        if (currentTargey == transform.position)
        {
            currentTargey = points[count];
            transform.LookAt(currentTargey);
        }
    }

    private void CalculationOfTarget()
    {
		if (transform.position == points[count] && count == numberOfPoints - 1)
		{
			forward = false;
			count--;
		}
		else if (transform.position == points[count] && count < numberOfPoints - 1 && forward == true)
		{
			count++;
		}
		else if (transform.position == points[count] && count >= 0 && forward == false)
		{
			count--;
		}
	}

    public void StartPatrol()
    {
		points = new Vector3[numberOfPoints];
		ArrayFilling();
        forward = true;
		count = 1;
		transform.position = points[0];
		currentTargey = points[count];
		transform.LookAt(currentTargey);
	}

    public void StopPatrol()
    {
        count = -1;
        gameObject.SetActive(false);
    }
}
