using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private bool isLever;
    private bool isLeverTwo;

    private void Update()
    {
        if(isLever == true && Input.GetKey(KeyCode.E))
        {
            GameObject.FindGameObjectWithTag("forVipu").SetActive(false);
        }

        if (isLeverTwo == true && Input.GetKey(KeyCode.E))
        {
            GameObject.FindGameObjectWithTag("forVipuTwo").SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lever"))
        {
            isLever = true;
            Debug.Log("on the lever");
        }

        if (collision.CompareTag("Lever2"))
        {
            isLeverTwo = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Lever"))
        {
            isLever = false;
            Debug.Log("not on the lever");
        }

        if (collision.CompareTag("Lever2"))
        {
            isLeverTwo = false;
        }
    }
}
