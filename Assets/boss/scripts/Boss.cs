using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	public string Name = "Why you no Name me :(";
	public int Health = 500;
	public int Charisma = 100;
	public int Gold = 500;

	//public Boss daBoss = new Boss ("Billy", 500, 100, 500);
	// Use this for initialization
	void Start () {
		Rigidbody2D daBoss = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
