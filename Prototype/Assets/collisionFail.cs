using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionFail : MonoBehaviour {



	public GUISkin mySkin;
	public Texture2D image_attention;
	public int flag_tmp = 0;
	private int flag = 0;
	private bool isTrigger = false;
	public Texture2D fond;	
	private Rigidbody rb;


	// Use this for initialization
	void Start () 
	{
		flag = 0;
		rb = GetComponent<Rigidbody>();
	}

	void OnCollisionEnter(Collision collision)  
	{
		if (collision.gameObject.name == "Terrain") {
			flag = 1;
			flag_tmp = 1;
			Debug.Log ("Message collision visible");
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			GameObject gameControllerObject = GameObject.Find("Main Camera");
			gameControllerObject.transform.Translate (Vector3.zero);
		}
		else if (collision.gameObject.name == "Arrivée") {
			flag = 2;
			flag_tmp = 1;
			Debug.Log ("Message collision visible");
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			GameObject gameControllerObject = GameObject.Find("Main Camera");
			gameControllerObject.transform.Translate (Vector3.zero);
		}
	}

	void OnGUI()
	{

		GUI.skin = mySkin;

		//fond = (Texture2D)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Textures/wasted.png", typeof(Texture2D));
		int l = 750; //largeur panneau
		int h = 750; //hauteur panneau
		int ox = Screen.width/2-l/2; //position panneau pour le centrer en X
		int oy = Screen.height/2-h/2; //position panneau pour le centrer en Y

		if(flag == 1)
		{  	
			//Affichage fond noir
			GUI.color = new Color( 1,1,1, 0.7f); //Permet d'afficher la DrawTexture avec de la transparence
			//GUI.DrawTexture(new Rect(0,0 ,Screen.width,Screen.height), fond);
			GUI.color = new Color( 1,1,1,1); //Permet de remettre la transparence à 1 pour les GUI suivants

			GUI.TextField(new Rect(ox,oy,l,h),"PERDU !");
		}
		else if(flag == 2)
		{  	
			//Affichage fond noir
			GUI.color = new Color( 1,1,1, 0.7f); //Permet d'afficher la DrawTexture avec de la transparence
			//GUI.DrawTexture(new Rect(0,0 ,Screen.width,Screen.height), fond);
			GUI.color = new Color( 1,1,1,1); //Permet de remettre la transparence à 1 pour les GUI suivants

			GUI.TextField(new Rect(ox,oy,l,h),"VICTOIRE !");
		}
	}
}
