using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGrasp_new : MonoBehaviour {
    public Rigidbody i1, i2, i3;
    // Use this for initialization

    Vector3 i1_min = new Vector3(285f, 165f, 10f), i1_max = new Vector3(275f, 122f, 320f);
    Vector3 i2_min = new Vector3(0, 0, 0f), i2_max = new Vector3(0, 0, 260f);
    Vector3 i3_min = new Vector3(0, 0, 0), i3_max = new Vector3(0, 0, 290f);
    Vector3 m_EulerAngleVelocity;
    void Start () {

        //Fetch the Rigidbody from the GameObject with this script attached
        //i1 = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        m_EulerAngleVelocity = i1.transform.localRotation.eulerAngles - i1_max;
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
        //i1.MoveRotation(i1.rotation * deltaRotation);

        i1.AddRelativeTorque(m_EulerAngleVelocity * Time.deltaTime);

    }
}
