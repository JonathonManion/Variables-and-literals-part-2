using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name = "Jonathon";

        print("Hello," + "my name is" + name + ". ");

        string teamates = "Vijay, Quincy, Simon, Sadat, Khalil and Isaac"; 

        print("My teamates are" + teamates + ".");

        string CustomizedMessage = "I'm looking forward to working and learning with";

        print(CustomizedMessage + teamates + "in the future.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
