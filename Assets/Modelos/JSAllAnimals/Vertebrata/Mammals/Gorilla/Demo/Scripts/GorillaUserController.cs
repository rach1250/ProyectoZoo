using UnityEngine;
using System.Collections;

public class GorillaUserController : MonoBehaviour {
	GorillaCharacter gorillaCharacter;
	public float aleatorio;
	
	void Start () {
		gorillaCharacter = GetComponent < GorillaCharacter> ();
		Acciones();
	}
	
	void Acciones () {		
		aleatorio = Random.Range(1,3);
		
		if(aleatorio == 1){
			StartCoroutine(Drum());
		}
		else if(aleatorio == 2){
			StartCoroutine(Sleeping());
		}
		else if(aleatorio == 3){
			StartCoroutine(Jump());
		}
		else if(aleatorio == 4){
			StartCoroutine(Attack());
		}
	}
	
	/*void Update () {	
		if (Input.GetButtonDown ("Fire1")) {
			gorillaCharacter.Attack();
		}
		if (Input.GetButtonDown ("Jump")) {
			gorillaCharacter.Jump();
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			gorillaCharacter.Hit();
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			gorillaCharacter.Death();
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			gorillaCharacter.Rebirth();
		}		
		if (Input.GetKeyDown (KeyCode.R)) {
			gorillaCharacter.Gallop();
		}				
		if (Input.GetKeyUp (KeyCode.R)) {
			gorillaCharacter.Walk();
		}		
		if (Input.GetKeyDown (KeyCode.U)) {
			gorillaCharacter.Drum();
		}	

		gorillaCharacter.forwardSpeed= gorillaCharacter.walkMode*Input.GetAxis ("Vertical");
		gorillaCharacter.turnSpeed= Input.GetAxis ("Horizontal");
	}*/
	
	private IEnumerator Drum(){
		yield return new WaitForSecondsRealtime(5);
		gorillaCharacter.Drum();
		yield return new WaitForSecondsRealtime(5);
	}
	
	private IEnumerator Sleeping()
    {
		yield return new WaitForSecondsRealtime(5);
		gorillaCharacter.Death();
        yield return new WaitForSecondsRealtime(30);
		gorillaCharacter.Rebirth();
    }
	
	private IEnumerator Jump(){
		yield return new WaitForSecondsRealtime(5);
		gorillaCharacter.Jump();
		yield return new WaitForSecondsRealtime(5);
	}
	
	private IEnumerator Attack(){
		yield return new WaitForSecondsRealtime(5);
		gorillaCharacter.Attack();
		yield return new WaitForSecondsRealtime(5);
	}
}
