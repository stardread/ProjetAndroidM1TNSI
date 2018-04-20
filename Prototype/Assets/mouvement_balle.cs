﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement_balle : MonoBehaviour
{
	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 250.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
}
