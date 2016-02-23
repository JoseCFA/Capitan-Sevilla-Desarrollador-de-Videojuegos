using UnityEngine;
using System.Collections;

public class StaticContainerOfStaticThings : MonoBehaviour {
	public static string myName;

	public static int labia;
	public static int duende;
	public static int logica;
	public static int illicidad;
	public static int concentracion;
	public static int atletismo;

	public static int sumaStats(){
		//Hola2
		return labia + duende + logica + illicidad + concentracion + atletismo;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
