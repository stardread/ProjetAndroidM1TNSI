using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
using UnityEngine;

public class rotation : MonoBehaviour {

    /*public float speed ;
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.left, speed , Space.Self);
		transform.Translate (Vector3.back * Time.deltaTime * speed);


		//transform.Rotate((Vector3.forward* Time.deltaTime), Space.Self);
	}*/
    public AudioClip GoldSound;
	public float speed;
    public Text countText;
	private Rigidbody rb;
    public Text time;
    private int count;
    private float temps;
    private int timeInt;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
        count = 0;
        temps = 0;
        SetScore();
    }

	void FixedUpdate()
	{
		GameObject gameControllerObject = GameObject.Find("Ball");
		collisionFail tmp = gameControllerObject.GetComponent<collisionFail> ();
		if (tmp.flag_tmp == 0) 
		{
			Vector3 movement = new Vector3 (0.0f, 0.0f, -1.0f);
			rb.AddForce (movement * speed);
		}

        SetTime();

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            MakeGoldSound();
            SetScore();
        }
    }

    void SetScore()
    {
        countText.text = "Points : " + count.ToString();

    }

    void SetTime()
    {
        timeInt = Mathf.RoundToInt(temps);
        time.text = ("Temps : " + timeInt + " seconde(s)");
        temps += Time.deltaTime;
    }

    public void MakeGoldSound()
    {
        AudioSource.PlayClipAtPoint(GoldSound, transform.position);
    }

}
