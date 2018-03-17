using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class buttonPress : MonoBehaviour {

	
	public List<int> codeNow = new List<int>();
	public List<int> constantCode = new List<int>() { 1, 9, 8, 8 };
	public GameObject door;
	public GameObject door2;
	public GameObject door3;
	public GameObject door4;
	public string numpadString;

	// Use this for initialization
	void Start () {
		

		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if(codeNow.SequenceEqual(constantCode))
		{
			Debug.Log("vsdcsv");
			door.GetComponent<ConstantForce>().enabled = false;
			door2.GetComponent<ConstantForce>().enabled = false;
			door3.GetComponent<ConstantForce>().enabled = false;
			door4.GetComponent<ConstantForce>().enabled = false;
			numpadString = "";
		}
		int lSize = codeNow.Count;
		if (lSize >= 4)
		{
			codeNow.Clear();
			numpadString = "";
		}
		
	}
}
