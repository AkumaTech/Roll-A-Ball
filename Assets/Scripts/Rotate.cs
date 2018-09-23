using System.Collections;
using UnityEngine;

public class Rotate : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

        transform.Rotate(new Vector3(15, 45, 90) * Time.deltaTime);
		
	}
}
