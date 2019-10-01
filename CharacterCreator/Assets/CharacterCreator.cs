using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreator : MonoBehaviour
{
    public Sprite[] skins = new Sprite[6]; //6 colors

    public Sprite[] mouths = new Sprite[3]; //3 styles

    public Sprite[] shirts = new Sprite[3]; //blue shirts 5 styles

    public Sprite[] pants = new Sprite[3]; //3 stlyes

    public Sprite[] hairs = new Sprite[7]; //  10 styles

    public Sprite[] assests = new Sprite[3]; //5 styles

    public float r;
    public float g;
    public float b;

    public SpriteRenderer skinSR;
    public SpriteRenderer mouthSR;
    public SpriteRenderer shirtSR;
    public SpriteRenderer pantsSR;
    public SpriteRenderer hairSR;
    public SpriteRenderer assestsSR;
    public SpriteRenderer shoesSR;

    private Color pink = new Color(.8f, .3f, .6f);
    private Color purple = new Color(.7f, .2f, .8f);
    private Color blue = new Color(.16f, .3f, 1f);
    private Color yellow = new Color(1f, .8f, .1f);
    private Color green = new Color(0f, .7f, .1f);
    private Color red = new Color(.8f, .1f, .1f);

    private Color white = new Color(1f, 1f, .8f);
    private Color blonde = new Color(1f, .9f, .1f);
    private Color brown = new Color(.4f, .26f, .05f);
    private Color brown2 = new Color(.25f, .1f, .05f);
    private Color orange = new Color(.1f, .9f, .5f);
    private Color black = new Color(.1f, .1f, .1f);


    // Start is called before the first frame update
    void Start()
    {
        skinSR.sprite = skins[2];
        mouthSR.sprite = mouths[0];
        hairSR.sprite = hairs[0];
        assestsSR.sprite = null;
    }

    

    // Update is called once per frame
    public void changeSkin(float x) //6 options
    {
        if(x > 4)
        {
            skinSR.sprite = skins[5];
        }
        else if (x > 3)
        {
            skinSR.sprite = skins[4];
        }
        else if (x > 2)
        {
            skinSR.sprite = skins[3];
        }
        else if (x > 1)
        {
            skinSR.sprite = skins[2];
        }
        else if (x > 0)
        {
            skinSR.sprite = skins[1];
        }
        else
        {
            skinSR.sprite = skins[0];
        }
    }

    public void changeMouth(float x) //3 options
    {
        if(x > 66)
        {
            mouthSR.sprite = mouths[2];
        }else if(x > 33)
        {
            mouthSR.sprite = mouths[1];
        }
        else
        {
            mouthSR.sprite = mouths[0];
        }
    }

    public void changeHairStyle(float x) //7 options
    {
        if (x > 86)
        {
            mouthSR.sprite = mouths[6];
        }
        else if (x > 72)
        {
            mouthSR.sprite = mouths[5];
        }
        else if (x > 58)
        {
            mouthSR.sprite = mouths[4];
        }
        else if (x > 44)
        {
            mouthSR.sprite = mouths[3];
        }
        else if (x > 30)
        {
            mouthSR.sprite = mouths[2];
        }
        else if (x > 16)
        {
            mouthSR.sprite = mouths[1];
        }
        else
        {
            mouthSR.sprite = mouths[0];
        }
    }

    public void changeHairColor(float x)//6
    {
        if (x > 4)
        {
            hairSR.color = white;
        }
        else if (x > 3)
        {
            hairSR.color = blonde;
        }
        else if (x > 2)
        {
            hairSR.color = red;
        }
        else if (x > 1)
        {
            hairSR.color = brown;
        }
        else if (x > 0)
        {
            hairSR.color = brown2;
        }
        else
        {
            hairSR.color = black;
        }
    }

    public void changeShirtStyle(float x)//3
    {
        if (x > 66)
        {
            shirtSR.sprite = shirts[2];
        }
        else if (x > 33)
        {
            shirtSR.sprite = shirts[1];
        }
        else
        {
            shirtSR.sprite = shirts[0];
        }
    }

    public void changeShirtColor(float x)//6
    {
        if (x > 4)
        {
            shirtSR.color = red;
        }
        else if (x > 3)
        {
            shirtSR.color = green;
        }
        else if (x > 2)
        {
            shirtSR.color = yellow;
        }
        else if (x > 1)
        {
            shirtSR.color = blue;
        }
        else if (x > 0)
        {
            shirtSR.color = purple;
        }
        else
        {
            shirtSR.color = pink;
        }
    }

    public void changePantStyle(float x)//3
    {
        if (x > 66)
        {
            pantsSR.sprite = pants[2];
        }
        else if (x > 33)
        {
            pantsSR.sprite = pants[1];
        }
        else
        {
            pantsSR.sprite = pants[0];
        }
    }

    public void changePantsColor(float x)//6
    {
        if (x > 4)
        {
            pantsSR.color = red;
        }
        else if (x > 3)
        {
            pantsSR.color = green;
        }
        else if (x > 2)
        {
            pantsSR.color = yellow;
        }
        else if (x > 1)
        {
            pantsSR.color = blue;
        }
        else if (x > 0)
        {
            pantsSR.color = purple;
        }
        else
        {
            pantsSR.color = pink;
        }
    }

    public void changeAssest(float x)//4
    {
        if (x > 75)
        {
            assestsSR.sprite = assests[2];
        }
        else if (x > 75)
        {
            assestsSR.sprite = assests[1];
        }
        else if (x > 25)
        {
            assestsSR.sprite = assests[0];
        }
        else
        {
            assestsSR.sprite = null;
        }
    }

    public void changeShoes(float x)
    {
        if (x > 4)
        {
            shoesSR.color = red;
        }
        else if (x > 3)
        {
            shoesSR.color = green;
        }
        else if (x > 2)
        {
            shoesSR.color = yellow;
        }
        else if (x > 1)
        {
            shoesSR.color = blue;
        }
        else if (x > 0)
        {
            shoesSR.color = purple;
        }
        else
        {
            shoesSR.color = pink;
        }
    }


}
