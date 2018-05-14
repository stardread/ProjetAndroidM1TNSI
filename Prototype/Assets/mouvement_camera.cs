using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement_camera : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		GameObject gameControllerObject = GameObject.Find("Ball");
		collisionFail tmp = gameControllerObject.GetComponent<collisionFail> ();
		if (tmp.flag_tmp == 0) {
			transform.Translate (Vector3.forward * Time.deltaTime * 3.5f);
		}
	}
}
