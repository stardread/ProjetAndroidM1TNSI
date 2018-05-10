using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionFail : MonoBehaviour {



	public GUISkin mySkin;
	public Texture2D image_attention;
	private bool flag = false;
	private bool isTrigger = false;
	public Texture2D fond;	


	// Use this for initialization
	void Start () 
	{
		flag = false;
	}

	void OnCollisionEnter(Collision collision)  
	{
		if (collision.gameObject.name == "Terrain") {
			flag = true;
			Debug.Log ("Message collision visible");
		}
	}

	/*void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.name == "Terrain") {
			flag = false;
			Debug.Log ("Message collision caché");
		}
	}*/

	void OnGUI()
	{

		GUI.skin = mySkin;

		fond = (Texture2D)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Textures/wasted.png", typeof(Texture2D));
		int l = 750; //largeur panneau
		int h = 750; //hauteur panneau
		int ox = Screen.width/2-l/2; //position panneau pour le centrer en X
		int oy = Screen.height/2-h/2; //position panneau pour le centrer en Y

		if(flag == true)
		{  	
			//Affichage fond noir
			GUI.color = new Color( 1,1,1, 0.7f); //Permet d'afficher la DrawTexture avec de la transparence
			GUI.DrawTexture(new Rect(0,0 ,Screen.width,Screen.height), fond);
			GUI.color = new Color( 1,1,1,1); //Permet de remettre la transparence à 1 pour les GUI suivants

			//GUI.DrawTexture(new Rect(ox,oy,l+30,h), "wasted");
			//GUI.TextField(new Rect(ox,oy,l,h),"PERDU !");
		}
	}
}
