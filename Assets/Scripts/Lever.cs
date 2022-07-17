using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private bool isLever;
    private bool isLeverTwo;
    private bool isButtonKTwo;
    private bool isButtonKThree;
    private bool isButtonKFive;

    [SerializeField] GameObject tikkaat;
    [SerializeField] GameObject kalteriKolme;
    [SerializeField] GameObject kalteriViis;
    [SerializeField] private AudioSource switchSound;

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
            switchSound.Play();
            tikkaat.SetActive(true);
        }

        if(isButtonKThree == true && Input.GetKey(KeyCode.E))
        {
            switchSound.Play();
            kalteriKolme.SetActive(false);
        }

        if (isButtonKFive == true && Input.GetKey(KeyCode.E))
        {
            switchSound.Play();
            kalteriViis.SetActive(false);
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

        if (collision.CompareTag("ButtonK3"))
        {
            isButtonKThree = true;
        }

        if (collision.CompareTag("ButtonK5"))
        {
            isButtonKFive = true;
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

        if (collision.CompareTag("ButtonK3"))
        {
            isButtonKThree = false;
        }

        if (collision.CompareTag("ButtonK5"))
        {
            isButtonKFive = false;
        }
    }
}
