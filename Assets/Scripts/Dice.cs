using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    // Array of dice sides sprites to load from Resources folder
    private Sprite[] diceSides;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;

    [SerializeField] GameObject map1;
    [SerializeField] GameObject map2;
    [SerializeField] GameObject map3;
    [SerializeField] GameObject map4;
    [SerializeField] GameObject map5;
    [SerializeField] GameObject map6;
    [SerializeField] GameObject diceScreen;
    [SerializeField] GameObject player;
    [SerializeField] GameObject henry;
    [SerializeField] GameObject actualDiceScreen;
    [SerializeField] private AudioSource nopanHeitto;

    // Use this for initialization
    private void Start () {

        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
	}

    // If you left click over the dice then RollTheDice coroutine is started
    private void OnMouseDown()
    {
        nopanHeitto.Play();
        StartCoroutine("RollTheDice");
    }

    // Coroutine that rolls the dice
    private IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        int randomDiceSide = 0;

        // Final side or value that dice reads in the end of coroutine
        int finalSide = 0;

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 10; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 6);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
        finalSide = randomDiceSide + 1;

        // Show final dice value in Console
        Debug.Log(finalSide);

        if (finalSide == 1)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Map 1");
            actualDiceScreen.SetActive(false);
            map1.SetActive(true);
            diceScreen.transform.position = new Vector2(-20, 0);
            player.SetActive(true);
            player.transform.position = new Vector3(3, -6.41f, 0);
            henry.transform.position = new Vector3(0, 0, 0);
        }
        else if(finalSide == 2)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Map 2");
            actualDiceScreen.SetActive(false);
            map2.SetActive(true);
            diceScreen.transform.position = new Vector2(-20, 0);
            player.SetActive(true);
            player.transform.position = new Vector3(-3.15f, -6.49f, 0);
            henry.transform.position = new Vector3(0, 0, 0);
        }
        else if (finalSide == 3)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Map 3");
            actualDiceScreen.SetActive(false);
            map3.SetActive(true);
            diceScreen.transform.position = new Vector2(-20, 0);
            player.SetActive(true);
            player.transform.position = new Vector3(0.37f, -6.46f, 0);
            henry.transform.position = new Vector3(0, 0, 0);
        }
        else if (finalSide == 4)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Map 4");
            actualDiceScreen.SetActive(false);
            map4.SetActive(true);
            diceScreen.transform.position = new Vector2(-20, 0);
            player.SetActive(true);
            player.transform.position = new Vector3(-3.11f, -6.41f, 0);
            henry.transform.position = new Vector3(0, 0, 0);
        }
        else if (finalSide == 5)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Map 5");
            actualDiceScreen.SetActive(false);
            map5.SetActive(true);
            diceScreen.transform.position = new Vector2(-20, 0);
            player.SetActive(true);
            player.transform.position = new Vector3(0.18f, -6.33f, 0);
            henry.transform.position = new Vector3(0, 0, 0);
        }
        else if (finalSide == 6)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Map 6");
            actualDiceScreen.SetActive(false);
            map6.SetActive(true);
            diceScreen.transform.position = new Vector2(-20, 0);
            player.SetActive(true);
            player.transform.position = new Vector3(3.84f, -6.62f, 0);
            henry.transform.position = new Vector3(0, 0, 0);
        }
    }
}
