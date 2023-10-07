using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private Runner runner1;
	[SerializeField] private Runner runner2;
	[SerializeField] private Runner runner3;
	[SerializeField] private Runner runner4;

	public void ResetScene()
	{
		runner1.StopRunning();
		runner1.ResetPositions();
		runner2.ResetPositions();
		runner3.ResetPositions();
		runner4.ResetPositions();
	}
}
