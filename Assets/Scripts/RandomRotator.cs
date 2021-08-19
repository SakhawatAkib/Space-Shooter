using UnityEngine;
using System.Collections;

/// <summary>
/// Gives an asteroid a random rotation animation.
/// </summary>
public class RandomRotator : MonoBehaviour 
{
	/// <summary>
	/// The asteroid tumble factor.
	/// </summary>
	public float tumble;
		
	void Start () 
	{
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
	}	
}
