using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {

    private int currentLevel = 0; //Would normally be in master script / scene controller
    private int sudsValue = 0;

    public Text SUDSRecord;
    public Text levelNumber;
    public Text output;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = 0;
        updateLevelText();
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
        sudsValue = (int)slider.value;
    }

    public void NextLevelPress() {
        updateSUDS();
        currentLevel += 1;
        updateLevelText();
    }

    public void PrevLevelPress() {
        //Don't want to submit score if we don't finish the level
        currentLevel -= 1;
        updateLevelText();
    }

    private void updateSUDS() {
        SUDSRecord.text += "L" + currentLevel + ": " + sudsValue + ", ";
    }

    private void updateLevelText() {
        levelNumber.text = "LEVEL: " + currentLevel;
    }


}
