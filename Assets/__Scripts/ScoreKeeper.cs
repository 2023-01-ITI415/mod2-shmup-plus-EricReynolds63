using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
	public GameObject mainGO;
	static private Text uiText;
	static private int score = 0;
	
    // Start is called before the first frame update
    void Awake()
    {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
		Main GC = mainGO.GetComponent<Main>();
        if (GC != null) {
			score = GC.score;
			uiText.text = "Score: " + score;
		}
    }
}
