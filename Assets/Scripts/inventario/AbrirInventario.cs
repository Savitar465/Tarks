using System;
using UnityEngine;
using System.Collections;

public class AbrirInventario : MonoBehaviour {

	public GameObject CamaraJugador;
	public GameObject CamaraInventario;
	private EjemploSimpleMove jugador;

	private void Start()
	{
		var play = GameObject.Find("Player");
		jugador = play.GetComponent<EjemploSimpleMove>();
	}

	void Update () {
		
		if (Input.GetKeyDown (KeyCode.I))
		{
			Cursor.lockState = CursorLockMode.None;
			jugador.noMovement(true);
			CamaraJugador.SetActive (false);
			CamaraInventario.SetActive (true);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Cursor.lockState = CursorLockMode.Locked;
			jugador.noMovement(false);
			CamaraJugador.SetActive (true);
			CamaraInventario.SetActive (false);
		}
	}
}
