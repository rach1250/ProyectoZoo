using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraScript : MonoBehaviour
{
	float heightMax = 10f;
	float heightMin = 3f;
	float scrollSpeed = 5f;
	float height;
 
	// Start is called before the first frame update
    void Start()
    {
		
	}

	void Update()
	{
		height += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
		height = Mathf.Clamp(height, heightMin, heightMax); 
	}
	
    // Update is called once per frame
    void FixedUpdate(){
		float mouseX = (Input.mousePosition.x / Screen.width ) - 0.8f;
		float mouseY = (Input.mousePosition.y / Screen.height) - 0.8f;
		
		transform.localRotation = Quaternion.Euler (new Vector4 (-1f * (mouseY * 90f), mouseX * 360f, transform.localRotation.z));
	}
}