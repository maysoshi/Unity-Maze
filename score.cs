using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    public GameObject boxGuy; // Reference to the welcome text GameObject

    public Collisions script1;

    void Start()
    {
        script1 = boxGuy.GetComponent<Collisions>();
        // if (script1 == null) {
        //     Debug.Log("its null");
        // }
        // if (script1.collectibleCounter == null){
        //     Debug.Log("counter null");
        // }
    }

    // Update is called once per frame
    void Update()
    {
        // if (script1 == null) {
        //     Debug.Log("its null");
        // }
        // if (script1.collectibleCounter == null){
        //     Debug.Log("counter null");
        // }
        // Debug.Log($"Current Score = {script1.collectibleCounter}");
        scoreText.text = $"Current Score = {script1.collectibleCounter}";
    }


}
