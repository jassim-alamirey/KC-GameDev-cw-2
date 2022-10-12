using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2_car : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "CodeMan";
        int heroHeight = 195+5;
        int heroAge = 20;
        string heroSuperPower = "LaserEyes";

        string villainName = "Mr.Evil";
        int vililanHeight = 165;
        int villainAge = 45;
        string villainSuperPower = "None";

        int ageDifference = (villainAge - heroAge);
        print("My name is " + heroName + ",My height is " + heroHeight + " I am " + heroAge + "years old, and my superpower is " + heroSuperPower);
        print("My name is " + villainName + ",My height is " + vililanHeight + " I am " + villainAge + "years old, and my superpowers are " + villainSuperPower);
        print("The Agediffrence is " + ageDifference);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
