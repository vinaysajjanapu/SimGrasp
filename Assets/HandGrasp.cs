using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGrasp : MonoBehaviour {

    public Transform i1, i2, i3; //Index finger joints  
    public Transform m1, m2, m3; //Middle finger joints
    public Transform r1, r2, r3; //Ring finger joints
    public Transform p1, p2, p3; //Pinky finger joints 
    public Transform t1, t2, t3; //Thumb joints

    public static bool indexTouched = false, middleTouched = false, ringTouched = false, pinkyTouched = false, thumbTouched = false, palmTouched = false;


    Vector3 i1_min = new Vector3(295f, 100f, 53f),      i1_max = new Vector3(275f, 122f, 320f);
    Vector3 i2_min = new Vector3(0, 0, 0f),             i2_max = new Vector3(0, 0, 260f);
    Vector3 i3_min = new Vector3(0, 0, 0),              i3_max = new Vector3(0, 0, 290f);

    Vector3 m1_min = new Vector3(268f, 217f, 305f),     m1_max = new Vector3(270f, 135f, 310f);
    Vector3 m2_min = new Vector3(0, 0, 0f),             m2_max = new Vector3(0, 0, 260f);
    Vector3 m3_min = new Vector3(0, 0, 0),              m3_max = new Vector3(0, 0, 290f);

    Vector3 r1_min = new Vector3(285f, 260f, 260f),     r1_max = new Vector3(275f, 307f, 140f);
    Vector3 r2_min = new Vector3(0, 0, 5f),             r2_max = new Vector3(0, 0, 260f);
    Vector3 r3_min = new Vector3(0, 0, 0),              r3_max = new Vector3(0, 0, 290f);

    Vector3 p1_min = new Vector3(333f, 344f, 160f),     p1_max = new Vector3(340f, 7f, 75f);
    Vector3 p2_min = new Vector3(0, 0, 10f),            p2_max = new Vector3(0, 0, 260f);
    Vector3 p3_min = new Vector3(0, 0, 0),              p3_max = new Vector3(0, 0, 300f);

    Vector3 t1_min = new Vector3(25f, 132f, 35f),       t1_max = new Vector3(2f, 145f, 13f);
    Vector3 t2_min = new Vector3(0, 0, 0),              t2_max = new Vector3(5, 3, 297f);
    Vector3 t3_min = new Vector3(0, 0, 10f),            t3_max = new Vector3(355, 0, 310f);


    /*
    Vector3 i1_min = new Vector3(285f, 165f, 10f), i1_max = new Vector3(275f, 122f, 320f);
    Vector3 i2_min = new Vector3(0, 0, 0f), i2_max = new Vector3(0, 0, 260f);
    Vector3 i3_min = new Vector3(0, 0, 0), i3_max = new Vector3(0, 0, 290f);

    Vector3 m1_min = new Vector3(268f, 150f, 25f), m1_max = new Vector3(270f, 135f, 310f);
    Vector3 m2_min = new Vector3(0, 0, 0f), m2_max = new Vector3(0, 0, 260f);
    Vector3 m3_min = new Vector3(0, 0, 0), m3_max = new Vector3(0, 0, 290f);

    Vector3 r1_min = new Vector3(275f, 304f, 234f), r1_max = new Vector3(275f, 307f, 140f);
    Vector3 r2_min = new Vector3(0, 0, 5f), r2_max = new Vector3(0, 0, 260f);
    Vector3 r3_min = new Vector3(0, 0, 0), r3_max = new Vector3(0, 0, 290f);

    Vector3 p1_min = new Vector3(345f, 14f, 160f), p1_max = new Vector3(340f, 7f, 75f);
    Vector3 p2_min = new Vector3(0, 0, 10f), p2_max = new Vector3(0, 0, 260f);
    Vector3 p3_min = new Vector3(0, 0, 0), p3_max = new Vector3(0, 0, 300f);

    Vector3 t1_min = new Vector3(10f, 145f, 35f), t1_max = new Vector3(2f, 145f, 13f);
    Vector3 t2_min = new Vector3(0, 0, 0), t2_max = new Vector3(5, 3, 297f);
    Vector3 t3_min = new Vector3(0, 0, 10f), t3_max = new Vector3(355, 0, 310f);*/

    /// Use this for initialization
    void Start () {

        float step = 250 * Time.deltaTime;
        OpenHand(step);
        //maxPositions();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.G))
        {
            float step = 160 * Time.deltaTime;
            StartGrasp(step);
        }
        else if(Input.GetKey(KeyCode.H))
        {
            float step = 250 * Time.deltaTime;
            OpenHand(step);
        }
    }
    

    void StartGrasp(float step)
    {

        if(!indexTouched || !palmTouched)
            CloseIndexFinger(step);

        if(!middleTouched || !palmTouched)
            CloseMiddleFinger(step);

        if(!ringTouched || !palmTouched)
            CloseRingFinger(step);

        if(!pinkyTouched || !palmTouched)
            ClosePinkyFinger(step);

        if(!thumbTouched)
            CloseThumbFinger(step);
    }

    void CloseThumbFinger(float step)
    {
        t1.localRotation = Quaternion.RotateTowards(t1.localRotation, Quaternion.Euler(t1_max), step / 5);
        t2.localRotation = Quaternion.RotateTowards(t2.localRotation, Quaternion.Euler(t2_max), step);
        t3.localRotation = Quaternion.RotateTowards(t3.localRotation, Quaternion.Euler(t3_max), step);
    }

    void CloseIndexFinger(float step)
    {
        i1.localRotation = Quaternion.RotateTowards(i1.localRotation, Quaternion.Euler(i1_max), step);
        i2.localRotation = Quaternion.RotateTowards(i2.localRotation, Quaternion.Euler(i2_max), step);
        i3.localRotation = Quaternion.RotateTowards(i3.localRotation, Quaternion.Euler(i3_max), step);
    }

    void CloseMiddleFinger(float step)
    {
        m1.localRotation = Quaternion.RotateTowards(m1.localRotation, Quaternion.Euler(m1_max), step);
        m2.localRotation = Quaternion.RotateTowards(m2.localRotation, Quaternion.Euler(m2_max), step);
        m3.localRotation = Quaternion.RotateTowards(m3.localRotation, Quaternion.Euler(m3_max), step);
    }

    void CloseRingFinger(float step)
    {
        r1.localRotation = Quaternion.RotateTowards(r1.localRotation, Quaternion.Euler(r1_max), step);
        r2.localRotation = Quaternion.RotateTowards(r2.localRotation, Quaternion.Euler(r2_max), step);
        r3.localRotation = Quaternion.RotateTowards(r3.localRotation, Quaternion.Euler(r3_max), step);

    }

    void ClosePinkyFinger(float step)
    {
        p1.localRotation = Quaternion.RotateTowards(p1.localRotation, Quaternion.Euler(p1_max), step);
        p2.localRotation = Quaternion.RotateTowards(p2.localRotation, Quaternion.Euler(p2_max), step);
        p3.localRotation = Quaternion.RotateTowards(p3.localRotation, Quaternion.Euler(p3_max), step);
    }

    void OpenHand(float step)
    {
        indexTouched = false;
        middleTouched = false;
        ringTouched = false;
        pinkyTouched = false;
        thumbTouched = false;
        palmTouched = false;
        
        i1.localRotation = Quaternion.RotateTowards(i1.localRotation, Quaternion.Euler(i1_min), step);
        m1.localRotation = Quaternion.RotateTowards(m1.localRotation, Quaternion.Euler(m1_min), step);
        r1.localRotation = Quaternion.RotateTowards(r1.localRotation, Quaternion.Euler(r1_min), step);
        p1.localRotation = Quaternion.RotateTowards(p1.localRotation, Quaternion.Euler(p1_min), step);
        t1.localRotation = Quaternion.RotateTowards(t1.localRotation, Quaternion.Euler(t1_min), step);

        i2.localRotation = Quaternion.RotateTowards(i2.localRotation, Quaternion.Euler(i2_min), step);
        m2.localRotation = Quaternion.RotateTowards(m2.localRotation, Quaternion.Euler(m2_min), step);
        r2.localRotation = Quaternion.RotateTowards(r2.localRotation, Quaternion.Euler(r2_min), step);
        p2.localRotation = Quaternion.RotateTowards(p2.localRotation, Quaternion.Euler(p2_min), step);
        t2.localRotation = Quaternion.RotateTowards(t2.localRotation, Quaternion.Euler(t2_min), step);

        i3.localRotation = Quaternion.RotateTowards(i3.localRotation, Quaternion.Euler(i3_min), step);
        m3.localRotation = Quaternion.RotateTowards(m3.localRotation, Quaternion.Euler(m3_min), step);
        r3.localRotation = Quaternion.RotateTowards(r3.localRotation, Quaternion.Euler(r3_min), step);
        p3.localRotation = Quaternion.RotateTowards(p3.localRotation, Quaternion.Euler(p3_min), step);
        t3.localRotation = Quaternion.RotateTowards(t3.localRotation, Quaternion.Euler(t3_min), step);

        /*
        i1.localRotation = Quaternion.Euler(i1_min);
        m1.localRotation = Quaternion.Euler(m1_min);
        r1.localRotation = Quaternion.Euler(r1_min);
        p1.localRotation = Quaternion.Euler(p1_min);
        t1.localRotation = Quaternion.Euler(t1_min);

        i2.localRotation = Quaternion.Euler(i2_min);
        m2.localRotation = Quaternion.Euler(m2_min);
        r2.localRotation = Quaternion.Euler(r2_min);
        p2.localRotation = Quaternion.Euler(p2_min);
        t2.localRotation = Quaternion.Euler(t2_min);

        i3.localRotation = Quaternion.Euler(i3_min);
        m3.localRotation = Quaternion.Euler(m3_min);
        r3.localRotation = Quaternion.Euler(r3_min);
        p3.localRotation = Quaternion.Euler(p3_min);
        t3.localRotation = Quaternion.Euler(t3_min);*/
    }
    
}
