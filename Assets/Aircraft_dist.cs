using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Aircraft_dist : MonoBehaviour {

	public Text wintext;
	public Transform other;
	public float closeDistance = 5.0F;
	public string tagline;

	// Use this for initialization
	void Start () {
		wintext.text = "";
	
	}
	
	// Update is called once per frame
	void Update () {
		if (other) {
			Vector3 offset = other.position - transform.position;
			float sqrLen = offset.sqrMagnitude;
			if (sqrLen < closeDistance * closeDistance)
				wintext.text = tagline;
			else {
				wintext.text = "";
				return;
			}
			

		}
	}
}
	
