using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NameStatsScript : MonoBehaviour {
	private Text text;


	public void changeName(string value){
		

	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Return)) {
			GameObject.Find ("TextField").SetActive (false);
			if (StaticContainerOfStaticThings.myName == null||StaticContainerOfStaticThings.myName == "" || StaticContainerOfStaticThings.myName.Length == 0) {
				StaticContainerOfStaticThings.myName = "Javier";
				print (StaticContainerOfStaticThings.myName);
			}
			GameObject.Find ("Texto").GetComponent<Text> ().text = "Ah, claro, mi nombre es " + StaticContainerOfStaticThings.myName + " si lo pone en mi DNI illo";
			StartCoroutine ("finish");
		}
	}

	private IEnumerator finish (){
		yield return new WaitForSeconds (4);
		SceneManager.LoadScene (2);
	}

}
