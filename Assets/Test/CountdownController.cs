using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace group1
{
    public class CountdownController : MonoBehaviour
    {
        public int countdownTime;
        public Text countdownDisplay;
        public Text final;
        private bool isShowing;
        public Transform RestartPoint;
        public GameObject Spawn;

        private void Start()
        {
            StartCoroutine(CountdowntoStart());
        }

        IEnumerator CountdowntoStart()
        {
            while (countdownTime > 0)
            {
    
                countdownDisplay.text = countdownTime.ToString();

                yield return new WaitForSeconds(1f);

                countdownTime--;
            }

            if (countdownTime > 0)
            {
                GetComponent<CharacterControl>().enabled = false;
            }

            final.gameObject.SetActive(true);

            yield return new WaitForSeconds(1f);

            countdownDisplay.gameObject.SetActive(false);
            final.gameObject.SetActive(false);

            transform.position = RestartPoint.position;

        }
    }
}


