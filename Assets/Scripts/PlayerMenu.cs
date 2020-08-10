using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMenu : MonoBehaviour
{
	public GameObject camera1, camera2, camera3;
	public int camara = 1;
	public string escena;
	
	void Start(){
		escena = SceneManager.GetActiveScene().name;
		camera1.SetActive(true);
		camera2.SetActive(false);
		camera3.SetActive(false);
	}
	
    public void LoadScene(){
		switch(escena){
			case "Leon Ambiente":
				SceneManager.LoadScene("Leon Vista Usuario");
				break;
			case "Gorila Ambiente":
				SceneManager.LoadScene("Gorila Vista Usuario");
				break;
			case "Elefante Ambiente":
				SceneManager.LoadScene("Elefante Vista Usuario");
				break;
			case "Oso Ambiente":
				SceneManager.LoadScene("Oso Vista Usuario");
				break;
			case "Cebra Ambiente":
				SceneManager.LoadScene("Cebra Vista Usuario");
				break;
			case "Jirafa Ambiente":
				SceneManager.LoadScene("Jirafa Vista Usuario");
				break;
		}
	}
	
	public void BackScene(){
		SceneManager.LoadScene("Menu de Seleccion");
	}
	
	public void NextCamera(){
		camara = camara + 1;
		if(camara == 4)
			camara = 1;
		
		switch (camara){
			case 1:
				camera1.SetActive(true);
				camera2.SetActive(false);
				camera3.SetActive(false);
				break;
			case 2:
				camera2.SetActive(true);
				camera1.SetActive(false);
				camera3.SetActive(false);
				break;
			case 3:
				camera3.SetActive(true);
				camera1.SetActive(false);
				camera2.SetActive(false);
				break;
		}
	}
}
