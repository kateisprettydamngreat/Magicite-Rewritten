using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Shine : MonoBehaviour
{
    private IEnumerator AnimateTexture() 
    {
        var r = GetComponent<Renderer>();
        
        for(int i = 0; i < 4; i++) 
        {
            r.material.mainTextureOffset = new Vector2(
                r.material.mainTextureOffset.x + 0.25f, 
                r.material.mainTextureOffset.y);
                
            yield return new WaitForSeconds(0.1f);
        }
    }

    public AudioClip soun;

    public int ra;
    
    private Renderer r;

    public GameObject g;

    private MenuScript gameScript;

    public int type;

    public virtual void Awake()
    {
        gameScript = (MenuScript)g.GetComponent("MenuScript");
    }

    public virtual void OnEnable()
    {        
    }

    public virtual IEnumerator Animate()
    {
        return AnimateTexture();
    }
    


	public virtual void OnMouseEnter()
	{
		GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/CLICKh", typeof(AudioClip)));
		if (type == 0)
		{
			gameScript.SetRace(ra);
		}
		else if (type == 1)
		{
			gameScript.SetHat(ra);
		}
		else
		{
			gameScript.SetComp(ra);
		}
	}

	public virtual void OnMouseExit()
	{
		gameScript.SetRace(99);
		gameScript.SetHat(99);
		gameScript.SetComp(99);
	}

	}