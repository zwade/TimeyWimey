using UnityEngine;
using System.Collections;


public class LinkedElement {
	public LinkedElement next;
	public LinkedElement prev;

	public Vector3 pos;

	public Vector3 velocity;

	public LinkedElement(Vector3 p, LinkedElement pre) {
		pos = p;
		prev = pre;
		prev.next = this;
		this.velocity = (prev.pos-this.pos)/((float)DataManagement.dt);
	}
}

public class DataManagement : MonoBehaviour {

	public static readonly double dt = 0.1;
	public static readonly double len = 120;

	public GameObject[] objects;

	private LinkedElement[] time;

	private float gameTime;
	private float isRunning = false;


	// Use this for initialization
	void Start () {
		time = new LinkedElement[(int)(1.0/DataManagement.dt*DataManagement.len)];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.getKeyDown("r")) {
			if (!isRunning) {
				InvokeRepeating("recordInterval",0,DataManagement.dt);
			} else {
				CancelInvoke();
			}
			isRunning = !isRunning;
		}
	}

	void recordInterval () {
		foreach (GameObject go in objects) {

	}
}
