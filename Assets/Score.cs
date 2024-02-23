using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject squarePrefab;
    [SerializeField] TMP_Text myText;
     public int points;

    public int Points
    {
        get { return points; }
        set { points = value; myText.text = points.ToString(); }
    }

    // Start is called before the first frame update
    void Start()
    {
        /*myText = FindObjectOfType<TMP_Text>();
        GameObject square = Instantiate(squarePrefab, transform);
        float x = Random.Range(0, GetComponent<RectTransform>().rect.width);
        float y = Random.Range(0, GetComponent<RectTransform>().rect.height);

        square.transform.position = new Vector2(x, y);*/
    }

    void OnClick()
    {
       // Destroy(squarePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = points.ToString();
    }
}
