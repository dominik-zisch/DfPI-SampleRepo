using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript: MonoBehaviour
{
    [Range(-10,10)]
    public int myNumber;
    private int _hiddenNumber;
    public Color[] colors;
    private MeshRenderer mr;
    
    // Start is called before the first frame update
    void Start()
    {
        colors = new []
        {
            Color.black,
            Color.blue,
            Color.green, 
            new (0.4f, 0.81f, 0.93f),
            Color.white
        };

        mr = GetComponent<MeshRenderer>();
        
        // No longer need this ib start
        // myNumber = Random.Range(-10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        // Get a random number, between 0 and the length of the color array
        myNumber = Random.Range(0, colors.Length);
       
        // make a random color by getting one color from the color array
        var randomColor = colors[myNumber];

        // access the mesh renderer, and set its material's color
        mr.material.color = randomColor;
        
    }
}
