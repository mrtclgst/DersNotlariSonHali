using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] Text textSkor;
    int _scorer;
    public static GameManager _instance { get; set; }
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }   
    }
    public void ChangeSkor(int sayac)
    {
        _scorer += sayac;
        textSkor.text = ("Skor: " + _scorer.ToString());
    }
}