using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;


 public class Menu : MonoBehaviour
{
    public UnityEngine.UI.InputField InputField;
    public SteamVR_Action_Boolean Trigger_R = null;
    public float alpha;
    public GameObject Canvas;
    public CanvasGroup canvasGroup;
    public GameObject Blank;
    public CanvasGroup BlankGroup;
    public int counter;
    private void Start()
    {
        Canvas.GetComponent<CanvasGroup>();
        Blank.GetComponent<CanvasGroup>();
        BlankGroup.alpha = 1;

    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            canvasGroup.alpha = 0;
            BlankGroup.alpha = 0;
            InputField.interactable = false;
            return;
        }

        if (Trigger_R.GetStateDown(SteamVR_Input_Sources.Any))
        {
            BlankGroup.alpha = 1;
        }
        if (Trigger_R.GetStateUp(SteamVR_Input_Sources.Any))
        {
            BlankGroup.alpha = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BlankGroup.alpha = 1;
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            BlankGroup.alpha = 0;
        }
    
        if (Trigger_R.GetStateUp(SteamVR_Input_Sources.Any))
        {
            counter++;
            Debug.Log("Block" + counter);
            Block();
        }
            if (Input.GetKeyDown(KeyCode.Escape))
        {
            counter--;
            
        }
        
    }
    private void Block()
    {
        if ((counter == 15) || (counter == 28) ||(counter >= 41))
        {

            BlankGroup.alpha = 1;
            return;
        }
        

    }
}
