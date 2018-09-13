using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

[System.Serializable]
public class TrainingSet
{
	public double[] input;
	public double output;
}

public class Perceptron : MonoBehaviour
{
	public TrainingSet[] ts;	

	void Start()
	{

	}

	void Update()
	{

	}
}