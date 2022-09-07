using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SuperSoupLibrary
{
    public class Main : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Game ... start!");
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }   
        }
    }
}
