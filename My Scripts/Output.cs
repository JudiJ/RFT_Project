
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime;
using System;
using UnityEngine.UIElements;
using System.Globalization;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Output:MonoBehaviour
{
    public SteamVR_Action_Boolean Trigger_R = null;
    public GameObject Rod = null;
    public GameObject Frame = null;
    public GameObject Camera = null;
    public SteamVR_Action_Vector2 m_TurnValue = null;
    public GameObject Controller = null;
    public UnityEngine.UI.InputField InputField;
    public Vector3 TiltRod;
    public Vector3 TiltRodEarlier;
    public Vector3 TiltFrame;
    private String Name;
    private List<string[]> rowData = new List<string[]>();
    private int counter;
    private int counter2;

    private void Awake()
    {
        DateTime localDate = DateTime.Now;
         
        Name = System.DateTime.Now.ToString("HH-mm-ss");
    }

    void Start()
    {
        InputField.gameObject.SetActive(true);
        
        TiltRodEarlier = Vector3.zero;

        string[] rowDataTemp = new string[13];
        rowDataTemp[0] = "Timestamp";
        rowDataTemp[1] = "Trialnumber";
        rowDataTemp[2] = "Trigger";
        rowDataTemp[3] = "Z_Frame";
        rowDataTemp[4] = "Z_Rod";
        rowDataTemp[5] = "X_Controller_Input";
        rowDataTemp[6] = "Y_Controller_Input";
        rowDataTemp[7] = "X_Head";
        rowDataTemp[8] = "Y_Head";
        rowDataTemp[9] = "Z_Head";
        rowDataTemp[10] = "X_Head_Tilt";
        rowDataTemp[11] = "Y_Head_Tilt";
        rowDataTemp[12] = "Z_Head_Tilt";

        rowData.Add(rowDataTemp);
     
    }
    
    void Update()
    {
       
        TiltRod = Rod.transform.eulerAngles;
        TiltFrame = Frame.transform.eulerAngles;

        
        if (InputField.interactable == false)
        { Save(); }

        if (Input.GetMouseButtonDown(1))
            {
                Application.Quit();
            }
        
       
        if (Trigger_R.GetStateUp(SteamVR_Input_Sources.Any))
        {
            counter++;
           
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            counter--;
            // Save();
        }
        if (Trigger_R.GetStateDown(SteamVR_Input_Sources.Any))
        {
            counter2++;

        }
    }
    void Save()
    {
        string[]rowDataTemp = new string[13];
            rowDataTemp[0] = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fffff");//Time
            rowDataTemp[1] = counter.ToString(); //Trialnumber
            rowDataTemp[2] = counter2.ToString(); //Trialnumber
            rowDataTemp[3] = Frame.transform.eulerAngles.z.ToString();//z Tilt Frame
            rowDataTemp[4] = Rod.transform.eulerAngles.z.ToString();//z Tilt Rod
            rowDataTemp[5] = m_TurnValue.axis.x.ToString();//Movement x Axis
            rowDataTemp[6] = m_TurnValue.axis.y.ToString();//Movement y Axis
            rowDataTemp[7] = Camera.transform.localPosition.x.ToString();//x Position Head
            rowDataTemp[8] = Camera.transform.localPosition.y.ToString();//y Position Head
            rowDataTemp[9] = Camera.transform.localPosition.z.ToString();//z Position Head
            rowDataTemp[10] = Camera.transform.eulerAngles.x.ToString();//x Tilt Head
            rowDataTemp[11] = Camera.transform.eulerAngles.y.ToString();//y Tilt Head
            rowDataTemp[12] = Camera.transform.eulerAngles.z.ToString();//z Tilt Head


        rowData.Add(rowDataTemp);
        
      
            string[][] output = new string[rowData.Count][];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = rowData[i];
        }

        int length = output.GetLength(0);
        string delimiter = "/";

        StringBuilder sb = new StringBuilder();

        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));


        string filePath = GetPath();
        
        StreamWriter outStream = System.IO.File.CreateText(filePath);
        outStream.WriteLine(sb);
        outStream.Close();
        
    }

    // Following method is used to retrive the relative path as device platform
    string GetPath()
    {
#if UNITY_EDITOR
      //  return Application.dataPath + "/CSV_RFT/"  + DateTime.Now.ToLongDateString() + "_" + InputField.text.ToString() + ".csv";
        return "C:/Users/Josupeit/Desktop/CSV_RFT/" + DateTime.Now.ToLongDateString() + "_" + Name + "_" + InputField.text.ToString() + ".csv";
#else
       return Application.dataPath + "/"  + DateTime.Now.ToLongDateString() + "_" + Name + "_" + InputField.text.ToString() + ".csv";
#endif
    }
}




