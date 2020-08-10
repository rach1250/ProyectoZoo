using UnityEngine;
using System.Collections;

public class ElephantAlternateController : MonoBehaviour {
	ElephantCharacter elephantCharacter;
	public int estado;
	
	void Start () {
		elephantCharacter = GetComponent < ElephantCharacter> ();		
	}	
		
	void Update () {
		
	}
	
	public void Parar() {
		elephantCharacter.forwardSpeed = 0f;
	}
	
	public void Caminar() {
		elephantCharacter.forwardSpeed = 1f;
	}
	public void Trotar() {
		elephantCharacter.forwardSpeed = 2f;
	}
}
