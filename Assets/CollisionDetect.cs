using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        string collider_name = col.collider.name;

        if(collider_name.Equals("hands:b_l_index1") || collider_name.Equals("hands:b_l_index2") || collider_name.Equals("hands:b_l_index3"))
        {
            HandGrasp.indexTouched = true;
        }
        if (collider_name.Equals("hands:b_l_middle1") || collider_name.Equals("hands:b_l_middle2") || collider_name.Equals("hands:b_l_middle3"))
        {
            HandGrasp.middleTouched = true;
        }
        if (collider_name.Equals("hands:b_l_ring1") || collider_name.Equals("hands:b_l_ring2") || collider_name.Equals("hands:b_l_ring3"))
        {
            HandGrasp.ringTouched = true;
        }
        if (collider_name.Equals("hands:b_l_pinky1") || collider_name.Equals("hands:b_l_pinky2") || collider_name.Equals("hands:b_l_pinky3"))
        {
            HandGrasp.pinkyTouched = true;
        }
        if (collider_name.Equals("hands:b_l_thumb1") || collider_name.Equals("hands:b_l_thumb2") || collider_name.Equals("hands:b_l_thumb3"))
        {
            HandGrasp.thumbTouched = true;
        }

        if (collider_name.Equals("hands:b_l_hand"))
        {
            HandGrasp.palmTouched = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        string collider_name = col.collider.name;
        /*
        if (collider_name.Equals("hands:b_l_index1") || collider_name.Equals("hands:b_l_index2") || collider_name.Equals("hands:b_l_index3"))
        {
            HandGrasp.indexTouched = false;
        }
        if (collider_name.Equals("hands:b_l_middle1") || collider_name.Equals("hands:b_l_middle2") || collider_name.Equals("hands:b_l_middle3"))
        {
            HandGrasp.middleTouched = false;
        }
        if (collider_name.Equals("hands:b_l_ring1") || collider_name.Equals("hands:b_l_ring2") || collider_name.Equals("hands:b_l_ring3"))
        {
            HandGrasp.ringTouched = false;
        }
        if (collider_name.Equals("hands:b_l_pinky1") || collider_name.Equals("hands:b_l_pinky2") || collider_name.Equals("hands:b_l_pinky3"))
        {
            HandGrasp.pinkyTouched = false;
        }
        if (collider_name.Equals("hands:b_l_thumb1") || collider_name.Equals("hands:b_l_thumb2") || collider_name.Equals("hands:b_l_thumb3"))
        {
            HandGrasp.thumbTouched = false;
        }
        */
        if (collider_name.Equals("hands:b_l_hand"))
        {
            HandGrasp.palmTouched = false;
        }
    }

}
