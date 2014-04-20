using UnityEngine;
using System.Collections;

public class Cubes : MonoBehaviour {

	private float delay = 0.2f;
	public GameObject cube;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", delay, delay);
	}
	
	// Update is called once per frame
	void Spawn () {
		Instantiate (cube, new Vector3 (Random.Range (-6, 6), 10, 0), Quaternion.identity);
	}
}
