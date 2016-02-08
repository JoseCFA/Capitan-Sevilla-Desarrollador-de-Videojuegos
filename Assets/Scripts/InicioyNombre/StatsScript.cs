using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class StatsScript : MonoBehaviour {

	private Text number;

	// Use this for initialization
	void Start () {
		number = GameObject.Find ("Puntos").GetComponent<Text> ();
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Return) && number.text == "0" ) {
			SceneManager.LoadScene (3);
			print ("Yep");
		}
	}
	public void IlliciCambio(Single value){
		StaticContainerOfStaticThings.illicidad = (int)value;
		number.text = (10 - StaticContainerOfStaticThings.sumaStats ()).ToString ();
	}

	public void AtletiCambio(Single value){
		StaticContainerOfStaticThings.atletismo = (int)value;
		number.text = (10 - StaticContainerOfStaticThings.sumaStats ()).ToString ();
	}

	public void DuendeCambio(Single value){
		StaticContainerOfStaticThings.duende = (int)value;
		number.text = (10 - StaticContainerOfStaticThings.sumaStats ()).ToString ();
	}

	public void LabiaCambio(Single value){
		StaticContainerOfStaticThings.labia = (int)value;
		number.text = (10 - StaticContainerOfStaticThings.sumaStats ()).ToString ();
	}

	public void LogiCambio(Single value){
		StaticContainerOfStaticThings.logica = (int)value;
		number.text = (10 - StaticContainerOfStaticThings.sumaStats ()).ToString ();
	}

	public void ConcentraCambio(Single value){
		StaticContainerOfStaticThings.concentracion = (int)value;
		number.text = (10 - StaticContainerOfStaticThings.sumaStats ()).ToString ();
	}
	
}
