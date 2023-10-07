using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    static private Runner currentRunner;

    [SerializeField] private Runner target;
    [SerializeField] private float speed;
    private Vector3 startPosition;

	private void Start()
	{
        startPosition = transform.position;
	}
	void Update()
    {
        if (this == currentRunner)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        }
        if (transform.position == target.transform.position)
        {
           target.StartRunning();
        }
    }

    public void StartRunning()
    {
        if (target != null)
        {
            transform.LookAt(target.transform);
            currentRunner = this;
        }
    }

    public void StopRunning()
    {
        currentRunner = null;
    }

    public void ResetPositions()
    {
        transform.position = startPosition;
    }
}
