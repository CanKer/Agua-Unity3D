using UnityEngine;
using System.Collections;

public class Flotar : MonoBehaviour {

	public float nivelAgua = 39.75F;
	public float flotarAltura = 1.0F;
	public float rebote = 0.15F;
	public Vector3 flotabilidadCentral;

	private float fuerza;
	private Vector3 puntoA;
	private Vector3 sustentacion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		puntoA = transform.position + transform.TransformDirection(flotabilidadCentral);
		fuerza = 1f - ((puntoA.y - nivelAgua) / flotarAltura);
		
		if (fuerza > 0f) 
		{
		//	sustentacion = -Physics.gravity * (fuerza - GetComponent.Rigidbody().velocity.y * rebote)
			sustentacion = -Physics.gravity * (fuerza - GetComponent<Rigidbody>().velocity.y * rebote);
			//GetComponent.Rigidbody().AddForceAtPosition(sustentacion, puntoA);
			GetComponent<Rigidbody>().AddForceAtPosition(sustentacion, puntoA);
		}
	}
	}

