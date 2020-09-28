using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionMark : MonoBehaviour
{
    private Material myQMaterial;
    public float amplify = 150;
    private float yValue = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        myQMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        yValue += 1 * amplify * Time.deltaTime;
        if (yValue > 20)
        {
            myQMaterial.mainTextureOffset = new Vector2(1, (myQMaterial.mainTextureOffset.y + .2f) % 1);
            yValue = 0;
        }
    }
}
