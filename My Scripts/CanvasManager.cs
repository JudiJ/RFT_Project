using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasManager : MonoBehaviour
{
    public GameObject Canvas;
    public Button Startbutton;
    
    void Start()
    {
        Button btn = Startbutton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
    }
    
    public void TaskOnClick()
    {
        Debug.Log("click");
        Canvas[] gameObject = GetComponentsInChildren<Canvas>();
        foreach (Canvas canvas in gameObject)
            {
            Canvas.gameObject.SetActive(false);
            }
      
    }
}
