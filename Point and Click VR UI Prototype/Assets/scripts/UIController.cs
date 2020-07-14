using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {

    public Text output;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick() {
        Debug.Log("Hello the button");
    }

    public void SUDSButtonInput(string value) {
   
        output.text += value + ", ";
    }

    public void SliderChange(Slider slider) {
        output.text = slider.value.ToString();
    }
}
