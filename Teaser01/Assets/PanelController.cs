using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DeactivatePanels();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchPanel(string panelName)
    {
        Debug.Log("----------" + panelName);
        int numberOfChildren = GameObject.Find("Canvas").transform.childCount;
        for(int i = 0; i < numberOfChildren; i++)
        {
            GameObject.Find("Canvas").transform.GetChild(i).gameObject.SetActive(false);
        }
        GameObject.Find("Canvas").transform.GetChild(int.Parse(panelName)).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(true); //this is the button
    }

    private void DeactivatePanels()
    {
        Debug.Log("Passou pelo Deactivate");
        int numberOfChildren = GameObject.Find("Canvas").transform.childCount;
        for (int i = 0; i < numberOfChildren; i++)
        {
            GameObject.Find("Canvas").transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void CloseScreen()
    {
        GameObject.FindWithTag("m1").SetActive(false);
        GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(false); //this is the button
    }
}
