using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {


    // Use this for initialization
    void Start()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision detected");

        //try to divide each joints.

        //ORIGINAL
        if(collision.collider.name.Equals("hands:b_r_thumb1") || collision.collider.name.Equals("hands:b_r_thumb2") || collision.collider.name.Equals("hands:b_r_thumb3"))
        {
            HandGrasping.thumbTouched = true;
            Debug.Log("Touched: Thumb ");
        }

        //REVISED
        //if (collision.collider.name.Equals("hands:b_r_thumb1"))
        //{
        //    HandGrasping.t1Touched = true;
        //    Debug.Log("Touched: T1");

        //    if(collision.collider.name.Equals("hands:b_r_thumb2"))
        //    {
        //        HandGrasping.t2Touched = true;
        //        Debug.Log("Touched: T2");

        //        if (collision.collider.name.Equals("hands:b_r_thumb3"))
        //            {
        //            HandGrasping.t3Touched = true;
        //            Debug.Log("Touched: T3");
        //            }
        //    }
        //}


        //ORIGINAL INDEX

        if (collision.collider.name.Equals("hands:b_r_index1") || collision.collider.name.Equals("hands:b_r_index2") || collision.collider.name.Equals("hands:b_r_index3"))
        {
            HandGrasping.indexTouched = true;
            Debug.Log("Touched: index ");
        }

        //if index3 hasn't touched the object but index1 or index2 has touched so the motion stopped, index3 still need to touch the object.
        //REVISED INDEX
        /*
        if (collision.collider.name.Equals("hands:b_r_index1"))
        {
            HandGrasping.i1Touched = true;
            Debug.Log("Touched: I1");

            if (collision.collider.name.Equals("hands:b_r_index2"))
            {
                HandGrasping.i2Touched = true;
                Debug.Log("Touched: I2");

                if (collision.collider.name.Equals("hands:b_r_index3"))
                {
                    HandGrasping.i3Touched = true;
                    Debug.Log("Touched: I3");
                }
            }
        }
      */



        if (collision.collider.name.Equals("hands:b_r_middle1") || collision.collider.name.Equals("hands:b_r_middle2") || collision.collider.name.Equals("hands:b_r_middle3"))
        {
            HandGrasping.middleTouched = true;
            Debug.Log("Touched: middle ");
        }

        if (collision.collider.name.Equals("hands:b_r_ring1") || collision.collider.name.Equals("hands:b_r_ring2") || collision.collider.name.Equals("hands:b_r_ring3"))
        {
            HandGrasping.ringTouched = true;
            Debug.Log("Touched: ring ");
        }

        if (collision.collider.name.Equals("hands:b_r_pinky1") || collision.collider.name.Equals("hands:b_r_pinky2") || collision.collider.name.Equals("hands:b_r_pinky3"))
        {
            HandGrasping.pinkyTouched = true;
            Debug.Log("Touched: pinky ");
        }

        if (collision.collider.name.Equals("hands:b_r_hand"))
        {
            HandGrasping.palmTouched = true;
            Debug.Log("Touched: palm ");
        }


        //RAY CASTING
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.red, 50, true);
            if(collision.collider.name.Equals("hands:b_r_thumb3"))
            {
              //Debug.DrawRay(contact.point, contact.normal, Color.red, 50, true);
              Debug.Log("Thumb touched: " + contact.point);
            }

            if(collision.collider.name.Equals("hands:b_r_ring3"))
            {
              //Debug.DrawRay(contact.point, contact.normal, Color.green, 50, true);
              Debug.Log("Ring touched: " + contact.point);
            }

            if(collision.collider.name.Equals("hands:b_r_index3"))
            {
              //Debug.DrawRay(contact.point, contact.normal, Color.black, 50, true);
              Debug.Log("Index touched: " + contact.point);
            }

            if(collision.collider.name.Equals("hands:b_r_middle3"))
            {
              //Debug.DrawRay(contact.point, contact.normal, Color.blue, 50, true);
              Debug.Log("Middle touched: " + contact.point);
            }

            if(collision.collider.name.Equals("hands:b_r_pinky3"))
            {
              //Debug.DrawRay(contact.point, contact.normal, Color.cyan, 50, true);
              Debug.Log("Pinky touched : " + contact.point);
            }
            //Debug.Log(collision.collider.name + contact.point);
        }

        //Draw line
        // foreach (ContactPoint contact in collision.contacts) {
        //    Debug.DrawLine(contact.point, contact.point + contact.normal, Color.green, 2, false);
        // }



        /*
        string collider_name = collision.collider.name;


        if (collider_name.Equals("hands:b_r_index1") || collider_name.Equals("hands:b_r_index2") || collider_name.Equals("hands:b_r_index3"))
        {
            HandGrasping.indexTouched = true;
            Debug.Log("Touched: Index Finger");
        }

        if (collider_name.Equals("hands:b_r_middle1") || collider_name.Equals("hands:b_r_middle2") || collider_name.Equals("hands:b_r_middle3"))
        {
            HandGrasping.middleTouched = true;
            Debug.Log("Touched: Middle Finger");
        }
        if (collider_name.Equals("hands:b_r_ring1") || collider_name.Equals("hands:b_r_ring2") || collider_name.Equals("hands:b_r_ring3"))
        {
            HandGrasping.ringTouched = true;
            Debug.Log("Touched: Ring Finger");
        }
        if (collider_name.Equals("hands:b_r_pinky1") || collider_name.Equals("hands:b_r_pinky2") || collider_name.Equals("hands:b_r_pinky3"))
        {
            HandGrasping.pinkyTouched = true;
            Debug.Log("Touched: Pinky Finger");
        }

        if (collider_name.Equals("hands:b_r_thumb1") || collider_name.Equals("hands:b_r_thumb2") || collider_name.Equals("hands:b_r_thumb3"))
        {
            HandGrasping.thumbTouched = true;
            Debug.Log("Touched: Thumb");
        }

        if (collider_name.Equals("hands:b_r_hand"))
        {
            HandGrasping.palmTouched = true;
        }
        */

    }

    private void OnCollisionStay(Collision collision)
    {



    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision exited");
    }


}
