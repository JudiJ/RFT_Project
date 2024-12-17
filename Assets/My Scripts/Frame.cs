using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Frame : MonoBehaviour
{
    public SteamVR_Action_Boolean Trigger_R = null;
    public float rotationSpeed = 3;
    public int counter;
    private GameObject m_Frame;
    void Start()
    {
        transform.eulerAngles = Vector3.zero;
        counter = 0;
    }
    void Update()
    {
        if (Trigger_R.GetStateDown(SteamVR_Input_Sources.Any))
        {
            
            transform.eulerAngles = Vector3.zero;
            return;
        }
        if (Trigger_R.GetStateUp(SteamVR_Input_Sources.Any))
        {
            counter++;
            Debug.Log("Frame" + counter);
            TurnFrame();
        }
            if (Input.GetKeyDown(KeyCode.Escape))
        {
            counter--;
            transform.eulerAngles = Vector3.zero;
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Back Frame" + counter);
            TurnFrame();
        }
    }
    void TurnFrame()
    {
        if ((counter == 1) || (counter == 2) || (counter == 4) || (counter == 8) || (counter == 9) 
            || (counter == 10) || (counter == 17) || (counter == 18) || (counter == 22) 
            || (counter == 27) || (counter == 29) || (counter == 34) || (counter == 38) || (counter == 40))
        { Vector3 euler = transform.eulerAngles;
            euler.z = (-33f);
            transform.eulerAngles = euler;
            return;
        } 

        if ( (counter == 3) || (counter == 6) || (counter == 11) || (counter == 13) 
            || (counter == 16) || (counter == 21) || (counter == 23) || (counter == 25) || (counter == 30) 
            || (counter == 31) || (counter == 33) || (counter == 35))
        { Vector3 euler = transform.eulerAngles;
            euler.z = (0f);
            transform.eulerAngles = euler;
            return;
        }

        if ( (counter == 5) || (counter == 7) || (counter == 12) || (counter == 14)
            || (counter == 19) || (counter == 20) || (counter == 24) || (counter == 26) ||
            (counter == 32) || (counter == 36) || (counter == 37) || (counter == 39))
        {
            Vector3 euler = transform.eulerAngles;
            euler.z = (33f);
            transform.eulerAngles = euler;
            return;
        }

    } 
}
