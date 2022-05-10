using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;


public class PlayfabResigterBase
{
    public string _username, _email, _password, _repeatpassword;
    public string Username
    {
        get { return _username; }
        set
        {
            if (value.Length < 5 || value.Length > 15)
            {
                _username = value;
            }
        }
    }
    public string Email { get; set; }
    public string Password { get; set; }
    public string RepeatPassword { get; set; }
    public bool _isRegister { get; set; }
    public void RegisterEmail(string _username, string _email, string _password)
    {
        PlayFabClientAPI.RegisterPlayFabUser(new RegisterPlayFabUserRequest()
        {
            Username = _username,
            Email = _email,
            Password = _password
        },
         result =>
         {
             _isRegister = true;
             Debug.Log("Kayit Tamamlandi");
         },
          error =>
          {
              _isRegister = false;
              Debug.Log("Kayit Hatasi");
          });

    }
}
