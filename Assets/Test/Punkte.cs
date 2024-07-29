using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace group1
{
    public class Punkte : MonoBehaviour
    {
        public Text scoreText;
        public static int scoreCount;

        void Start()
        {

        }

        void Update()
        {
            scoreText.text = "" + Mathf.Round(scoreCount);
        }
    }
}
