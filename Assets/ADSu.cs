using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class ADSu : MonoBehaviour {

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
				wintext.text = "SUN " +
					"\nRadius: 695,700 km" +
					"\nSurface temperature: 5,777 K " +
					"\nDistance to Earth: 149.6 million km " +
					"\nMass: 1.989 × 10^30 kg " +
					"\nAbsolute magnitude: 4.83";
			else {
				wintext.text = "";
			}


		}
	}
}
