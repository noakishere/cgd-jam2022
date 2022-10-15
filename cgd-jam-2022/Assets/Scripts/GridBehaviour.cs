using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviour : MonoBehaviour
{
    [SerializeField] private Grid[] gridScriptableObject;
    private Grid myStyle;

    [SerializeField] private Color color;
    private SpriteRenderer _sprite;
    [SerializeField] private string text;
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        myStyle = gridScriptableObject[Random.Range(0, gridScriptableObject.Length)];

        text = myStyle.textTest;
        _sprite.color = myStyle.color;

        Debug.Log(text);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
