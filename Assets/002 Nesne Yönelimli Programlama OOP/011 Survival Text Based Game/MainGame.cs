using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainGame : MonoBehaviour
{
    
    public Text _merhabaTxt, _hitapTxt, _placeHolderTxt, _resultText,_sonucText;
    public InputField _adInput;
    string tasiyiciAd;
    private void Awake()
    {
        _merhabaTxt.text = "merhaba yolcu!";
        _hitapTxt.text = "sen buralardan değilsin.Kimsin sennn!";
        _placeHolderTxt.text = "benn...";
    }
    public void IsmiKontrolEt()
    {
        if (_adInput.text.Length>=11 || _adInput.text.Length == 0 || _adInput.text.Length < 3)
        {
            _resultText.text = "ismin bu olamaz";
            _resultText.color = Color.red;
            _sonucText.text = "";
            if (_adInput.text=="at"|| _adInput.text=="esek" )
            {

            }
        }
        else
        {
            tasiyiciAd = _adInput.text;
            _resultText.text = "Bu iyi gibi";
            _resultText.color = Color.green;
            Karsilama();
        }
    }
    public void Karsilama()
    {
        _sonucText.text = $"demek adın bu: {tasiyiciAd} !buna pek inanmadım.";
    }
}
