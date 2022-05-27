using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script animates the Ground which is a quad
//why does this HAVE to have _ in front of MainTex or else I get critical console errors?
public class GroundScroller : MonoBehaviour
{
    [SerializeField]
    private float scrollSpeed = 1.5f;

    // Update is called once per frame
    void Update()
    {
        //Gives you current offset
        Vector2 currentTextureOffset = this.GetComponent<Renderer>().material.GetTextureOffset("_MainTex");

        //Given amount to scroll this frame
        float distanceToScrollLeft = Time.deltaTime * scrollSpeed;

        //Calculate new offset (adds current + distance)
        float newTextureOffsetX = currentTextureOffset.x + distanceToScrollLeft;
        
        //Creates new Vector2 with the updated offset
        currentTextureOffset = new Vector2(newTextureOffsetX, currentTextureOffset.y);

        //Set the offset to our new value
        this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", currentTextureOffset);
    
    }
}
