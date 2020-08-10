using UnityEngine;
using System.Collections;

public class LionUserController : MonoBehaviour {
	LionCharacter lionCharacter;
	public float inputX, inputZ, aleatorio;	
	
	void Start () {
		lionCharacter = GetComponent < LionCharacter> ();
		Acciones();
	}	
		
	void Acciones () {		
		aleatorio = Random.Range(1,4);
		
		if(aleatorio == 0){
			StartCoroutine(Moving());
		}
		else if(aleatorio == 1){
			StartCoroutine(Sitting());
		}
		else if(aleatorio == 2){
			StartCoroutine(Lieying());
		}
		else if(aleatorio == 3){
			StartCoroutine(Sleeping());
		}
		else if(aleatorio == 4){
			StartCoroutine(Roar());			
		}
	}
	
	/*void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			lionCharacter.Attack();
		}
		if (Input.GetButtonDown ("Jump")) {
			lionCharacter.Jump();
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			lionCharacter.Hit();
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			lionCharacter.Death();
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			lionCharacter.Rebirth();
		}		
		if (Input.GetKeyDown (KeyCode.U)) {
			lionCharacter.StandUp();
		}		
		if (Input.GetKeyDown (KeyCode.J)) {
			lionCharacter.SitDown();
		}	
		if (Input.GetKeyDown (KeyCode.M)) {
			lionCharacter.LieDown();
		}		
		if (Input.GetKeyDown (KeyCode.N)) {
			lionCharacter.Sleep();
		}	
		if (Input.GetKeyDown (KeyCode.Y)) {
			lionCharacter.WakeUp();
		}	
		if (Input.GetKeyDown (KeyCode.R)) {
			lionCharacter.Roar();
		}		
		if (Input.GetKeyDown (KeyCode.G)) {
			lionCharacter.Gallop();
		}	
		if (Input.GetKeyDown (KeyCode.C)) {
			lionCharacter.Canter();
		}	
		if (Input.GetKeyDown (KeyCode.T)) {
			lionCharacter.Trot();
		}	
		if (Input.GetKeyUp (KeyCode.X)) {
			lionCharacter.Walk();
		}	

		lionCharacter.forwardSpeed=lionCharacter.maxWalkSpeed*Input.GetAxis ("Vertical");
		lionCharacter.turnSpeed= Input.GetAxis ("Horizontal");
	}*/
	
	private IEnumerator Moving(){
		lionCharacter.forwardSpeed = lionCharacter.maxWalkSpeed;
		
		yield return new WaitForSecondsRealtime(3);
		
		lionCharacter.forwardSpeed = 0f;
		
		//lionCharacter.turnSpeed= Input.GetAxis ("Horizontal");
	}
	
	private IEnumerator Roar(){
		lionCharacter.Roar();
		yield return new WaitForSecondsRealtime(5);
	}
	
	private IEnumerator Sitting()
    {
		lionCharacter.SitDown();
		Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSecondsRealtime(10);
		Debug.Log("Finished Coroutine at timestamp : " + Time.time);
		lionCharacter.StandUp();
		yield return new WaitForSecondsRealtime(10);
    }
	
	private IEnumerator Lieying()
    {
		lionCharacter.SitDown();
		Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSecondsRealtime(10);
		Debug.Log("Finished Coroutine at timestamp : " + Time.time);
		lionCharacter.LieDown();
		Debug.Log("Started Coroutine 2 at timestamp : " + Time.time);
		yield return new WaitForSecondsRealtime(10);
		lionCharacter.SitDown();
		yield return new WaitForSecondsRealtime(3);
		lionCharacter.StandUp();
		yield return new WaitForSecondsRealtime(10);
    }
	
	private IEnumerator Sleeping()
    {
		lionCharacter.SitDown();
        yield return new WaitForSecondsRealtime(10);
		lionCharacter.LieDown();
		yield return new WaitForSecondsRealtime(10);
		lionCharacter.Sleep();
		yield return new WaitForSecondsRealtime(30);
		lionCharacter.WakeUp();
		yield return new WaitForSecondsRealtime(5);
		lionCharacter.SitDown();
		yield return new WaitForSecondsRealtime(3);
		lionCharacter.StandUp();
		yield return new WaitForSecondsRealtime(10);
    }
}
