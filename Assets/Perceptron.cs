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
	double[] weights = {0,0};
	double bias = 0;
	double totalError = 0;

	void Start()
	{

	}

	void Update()
	{

	}
}