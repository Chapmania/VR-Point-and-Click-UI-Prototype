using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class SUDSButtonController : MonoBehaviour, IPointerClickHandler {

    UIController uiController;

    // Start is called before the first frame update
    void Start()
    {
        uiController = GameObject.Find("Canvas").GetComponent<UIController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPointerClick(PointerEventData eventData) {
        Debug.Log("CLICKED!!");
        uiController.SUDSButtonInput(this.gameObject.name);
    }
}
