using UnityEngine;
using System.Collections;


public class Player_1 : MonoBehaviour {
	public float velocidad = 5f;
	public float salto = 10f;
	public float power = 1f;


	private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey ("right")) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);

		}
		if (Input.GetKey ("left")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (Input.GetKey ("down")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.x);
			transform.localScale = new Vector3 (1, 1, -1);
		}

		if (Input.GetKey ("up")) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.x);
			transform.localScale = new Vector3 (1, 1, 1);
		}
	}



}

