using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ADJ : MonoBehaviour {

	public Text wintext;
	public Transform other;
	public float closeDistance = 5.0F;

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
				wintext.text = "JUPITER" +
					"\nRadius: 69,911 km" +
					"\nMass: 1.898 × 10^27 kg (317.8 M⊕)" +
					"\nGravity: 24.79 m/s²" +
					"\nSurface area: 61.42 billion km²";
			else {
				wintext.text = "";
			}


		}
	}
}

