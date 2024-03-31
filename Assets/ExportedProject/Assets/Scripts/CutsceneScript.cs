using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class CutsceneScript : MonoBehaviour
{
	 public GameObject[] shadeP;
	public GameObject woman1;
	public GameObject child1;
	public GameObject hand;
	public GameObject blood;
	public GameObject shade;
	public TextMesh txtQuote;
	public GameObject flash;
	public GameObject pic1;
	public GameObject pic2;
	public GameObject pic3;
	public GameObject pic4;
	public GameObject pic5;
	public GameObject pic6;
	public GameObject pic7;
    public virtual IEnumerator Start()
    {
        shade.SetActive(true);
        StartCoroutine(Write("\"Long ago there was\na time of peace.\""));
        yield return new WaitForSeconds(3f);
        
        shade.SetActive(false);
        txtQuote.gameObject.SetActive(false);
        txtQuote.text = string.Empty;
        pic1.SetActive(true);
        yield return new WaitForSeconds(3f);
        
        txtQuote.gameObject.SetActive(true);
        StartCoroutine(Write("\"We lived on the surface,\nfree of danger.\""));
        shade.SetActive(true);
        pic1.SetActive(false);
        yield return new WaitForSeconds(3f);
        
        shade.SetActive(false);
        txtQuote.text = string.Empty;
        txtQuote.gameObject.SetActive(false);
        pic2.SetActive(true);
        yield return new WaitForSeconds(3f);
        
        shade.SetActive(true);
        pic2.SetActive(false);
        txtQuote.gameObject.SetActive(true);
        StartCoroutine(Write("\"But something happened...\""));
        yield return new WaitForSeconds(3f);
        
        shade.SetActive(false);
        txtQuote.text = string.Empty;
        txtQuote.gameObject.SetActive(false);
        pic1.SetActive(true);
        yield return new WaitForSeconds(1f);
        
        StartCoroutine(ScreenFlash());
        pic1.SetActive(false);
        pic3.SetActive(true);
        yield return new WaitForSeconds(4f);
        
        shade.SetActive(true);
        pic3.SetActive(false);
        txtQuote.gameObject.SetActive(true);
        StartCoroutine(Write("The Scourge was unleashed\nupon the world.\nMany of us died."));
        yield return new WaitForSeconds(3f);
        
        pic4.SetActive(true);
        txtQuote.text = string.Empty;
        txtQuote.gameObject.SetActive(false);
        shade.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        
        hand.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.4f);
        
        blood.SetActive(true);
        woman1.GetComponent<Animation>().Play("d");
        child1.GetComponent<Animation>().Play("d");
        yield return new WaitForSeconds(1f);
        
        pic4.SetActive(false);
        shade.SetActive(true);
        txtQuote.gameObject.SetActive(true);
        StartCoroutine(Write("\"The rest of us sought\nshelter underground.\""));
        yield return new WaitForSeconds(3f);
        
        shade.SetActive(false);
        pic5.SetActive(true);
        txtQuote.text = string.Empty;
        txtQuote.gameObject.SetActive(false);
        StartCoroutine(ShadowPeople());
        yield return new WaitForSeconds(3f);
        
        pic5.SetActive(false);
        shade.SetActive(true);
        txtQuote.gameObject.SetActive(true);
        StartCoroutine(Write("\"But amidst all of this chaos,\nWe found hope...\""));
        yield return new WaitForSeconds(3f);
        
        txtQuote.text = string.Empty;
        txtQuote.gameObject.SetActive(false);
        shade.SetActive(false);
        pic6.SetActive(true);
        yield return new WaitForSeconds(3f);
        
        pic6.SetActive(false);
        shade.SetActive(true);
        txtQuote.gameObject.SetActive(true);
        txtQuote.text = "...Magicite.";
    }

    public virtual IEnumerator ShadowPeople()
    {
        shadeP[0].GetComponent<Animation>().Play();
        yield return new WaitForSeconds(1f);

        shadeP[1].GetComponent<Animation>().Play();
        yield return new WaitForSeconds(1f);

        shadeP[2].GetComponent<Animation>().Play();
    }


    public virtual IEnumerator ScreenFlash()
    {
        flash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        flash.SetActive(false);
    }

    public virtual IEnumerator Write(string s)
    {
        int i = 0;
        txtQuote.text = string.Empty;

        while (i < s.Length)
        {
            txtQuote.text += s[i];
            i++;
            yield return new WaitForSeconds(0.01f);
        }
    }

	public CutsceneScript()
	{
		shadeP = new GameObject[3];
	}
	}