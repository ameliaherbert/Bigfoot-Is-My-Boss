//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//increases and decreases slider objects for romance bar and investigation bar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class RomanceSlider : MonoBehaviour
{
    public Slider currentValue;

    public Slider romanceBar;

    private void Start()
    {
        currentValue.value = 0;
    }

    [YarnCommand("romanceSlider")]
    public void TakeRomance(int add)
    {
        currentValue.value += add;

    }

    [YarnCommand("disableSlider")]
    public void DisableSlider()
    {
        romanceBar.gameObject.SetActive(false);
    }

    [YarnCommand("enableSlider")]
    public void EnableSlider()
    {
        romanceBar.gameObject.SetActive(true);
    }

}
