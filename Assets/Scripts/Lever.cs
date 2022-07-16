using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private bool isLever;
    private bool isLeverTwo;
    private bool isButtonKTwo;

    [SerializeField] GameObject tikkaat;

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

        if(isButtonKTwo == true && Input.GetKey(KeyCode.E))
        {
            tikkaat.SetActive(true);
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

        if (collision.CompareTag("ButtonK2"))
        {
            isButtonKTwo = true;
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

        if (collision.CompareTag("ButtonK2"))
        {
            isButtonKTwo = false;
        }
    }
}
