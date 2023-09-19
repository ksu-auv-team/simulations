using UnityEngine;
using UnityEngine.UI;
using System;

    

public class Raycast : MonoBehaviour
{

    public Text uiText;

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 200f))
        {
            //Debug.Log("Hit Something");
            uiText.text = hitinfo.distance.ToString();
        } else {
            //Debug.Log("no hit");
            uiText.text = "N/A";
        }
    }
}
