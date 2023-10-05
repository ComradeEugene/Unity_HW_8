using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runners : MonoBehaviour
{
    [SerializeField] private GameObject runner1;
    [SerializeField] private GameObject runner2;
    [SerializeField] private GameObject runner3;
    [SerializeField] private GameObject runner4;

    private Transform[] runners;
    void Start()
    {
        runners = new Transform[4];
        
    }
    void Update()
    {
        
    }
}
