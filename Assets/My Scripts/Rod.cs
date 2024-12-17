using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using System.IO;

public class Rod : MonoBehaviour


{
    public float m_Sensitivity = 1f;
    public float m_DirectionL = 1f;
    private float m_Direction = 0.5f;
    private Vector3 eulerAngles;
    public int counter;
    public SteamVR_Action_Boolean Turn_R = null;
    public SteamVR_Action_Boolean Trigger_R = null;
    public SteamVR_Action_Vector2 Direction_R = null;
  
    private GameObject m_Rod;

    public UnityEngine.UI.InputField InputField;

    void Start()
    {
        Vector3 euler = Vector3.zero;
        counter = 0;
    }
    void Update()
    {
        if (InputField.interactable == false)
        {
            Vector3 orientationEuler = new Vector3(m_Direction, 0, 0);
            Quaternion orientation = Quaternion.Euler(orientationEuler);
            Vector3 movement = Vector3.zero;

            if(Turn_R.state && counter <= 41)
            {

                m_Direction += Direction_R.axis.x * m_Sensitivity;
                m_Direction = Mathf.Clamp(m_Direction, -m_DirectionL, m_DirectionL);
                Vector3 euler = transform.eulerAngles;
                Turning_slow();
            }


            if (Trigger_R.GetStateDown(SteamVR_Input_Sources.Any))
            {

                transform.eulerAngles = Vector3.zero;
                
                return;
            }

            if (Trigger_R.GetStateUp(SteamVR_Input_Sources.Any))
            {
                counter++;
                Debug.Log("Rod" + counter);
                TurnRod();
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                
                counter--;
                transform.eulerAngles = Vector3.zero;
            }

            if (Input.GetKeyUp(KeyCode.Escape))
            {
                Debug.Log("Back Rod" + counter);
                TurnRod();

            }
            else
                return;
        }
    }
    private void Turning_slow()
    {
        if (m_Direction < 0 )
        {
            {
                Vector3 euler = transform.eulerAngles;
                euler.z += 0.1f;
                transform.eulerAngles = euler;
            }
         
        }
 
        if (m_Direction > 0 )
        {
            Vector3 euler = transform.eulerAngles;
            euler.z -= 0.1f;
            transform.eulerAngles = euler;
           
        }

    }
 
     void TurnRod()
    {

        if ( (counter == 2) || (counter == 6) || (counter == 7) || (counter == 10) || (counter == 21)
            || (counter == 22) || (counter == 26) || (counter == 32) || (counter == 33) || (counter == 34))
        {
            Vector3 euler = transform.eulerAngles;
            euler.z = (-11f);
            transform.eulerAngles = euler;
            return;
        }
        if ( (counter == 4) || (counter == 12) || (counter == 13) || (counter == 24) 
            || (counter == 25) || (counter == 27) || (counter == 31) || (counter == 36) || (counter == 40))
        {
            Vector3 euler = transform.eulerAngles;
            euler.z = (11f);
            transform.eulerAngles = euler;
            return;
        }
        if ((counter == 3) ||  (counter == 8) || (counter == 14) || (counter == 16) 
            || (counter == 18) || (counter == 19) || (counter==35) || (counter == 37)|| (counter == 38) )
        {
            Vector3 euler = transform.eulerAngles;
            euler.z = (-22f);
            transform.eulerAngles = euler;
            return;
        }
        if ((counter == 1) || (counter == 5) || (counter == 9) || (counter == 11) || (counter == 17) 
            || (counter == 20) ||  (counter == 23) || (counter == 29) || (counter == 30) || (counter == 39))
        {
            Vector3 euler = transform.eulerAngles;
            euler.z = (22f);
            transform.eulerAngles = euler;
            return;
        }   
        
    }
}
    




