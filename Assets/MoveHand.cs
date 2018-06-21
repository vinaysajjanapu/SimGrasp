using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHand : MonoBehaviour {
    public GameObject graspObject;
    private GameObject hand;

	// Use this for initialization
	void Start () {
        //GameObject.Find;
        hand = GetComponent<GameObject>();
        Vector3 pos = graspObject.transform.position;        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100f);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.collider != null)
                {

                    GameObject touchedObject = hit.transform.gameObject;

                    Debug.Log("Touched " + touchedObject.transform.name);
                }
            }
        }
    }
}
