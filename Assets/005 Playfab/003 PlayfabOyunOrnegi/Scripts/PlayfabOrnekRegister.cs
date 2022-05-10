using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;
using System;

public class PlayfabOrnekRegister : MonoBehaviour
{
    PlayfabResigterBase _registerBase = new PlayfabResigterBase();
    [SerializeField] InputField _username, _password, _email, _repeatpassword;
    [SerializeField] GameObject _asyncPanel;
    [SerializeField] Button _registerButton;
    bool _isUpdateAvatar;
    public void RegisterOnClick()
    {
        StartCoroutine(AsyncRegister());
    }
    public void RegisterInputControl()
    {
        if (_email.text.IndexOf('@') < 0 && _email.text.IndexOf('.') < 0 || _password.text != _repeatpassword.text
        || _password.text.Length < 6 || _username.text.Length == 0)
        {
            _registerButton.interactable = false;
        }
        _username.text = Regex.Replace(_username.text, "[^\\w\\.]", "");
        _username.text = Regex.Replace(_repeatpassword.text, "[ç,ı,ü,ğ,ö,ş,İ,Ğ,Ü,Ö,Ş,Ç,.]", "");
        _password.text = Regex.Replace(_repeatpassword.text, "[ç,ı,ü,ğ,ö,ş,İ,Ğ,Ü,Ö,Ş,Ç]", "");
        _repeatpassword.text = Regex.Replace(_repeatpassword.text, "[ç,ı,ü,ğ,ö,ş,İ,Ğ,Ü,Ö,Ş,Ç]", "");
    }
    IEnumerator AsyncRegister()
    {
        _asyncPanel.SetActive(true);
        _registerBase.RegisterEmail(_username.text, _password.text, _email.text);
        yield return new WaitUntil(() => _registerBase._isRegister);
        updateAvatar();
        yield return new WaitUntil(() => _isUpdateAvatar = true);
        SceneManager.LoadScene(1);
        string b;
        DateTime c;

        PlayFabClientAPI.GetPlayerProfile(new GetPlayerProfileRequest(), result => { c = result.PlayerProfile.LastLogin; }, error => { });
        PlayFabClientAPI.GetAccountInfo(new GetAccountInfoRequest(), result => { b = result.AccountInfo.TitleInfo.DisplayName; }, error => { });


    }
    public void updateAvatar()
    {
        string _avatarURL = "//www.gravatar.com/userimage/219982673/4c1fbc74e07881b90bf4b182e233ee23?size=256";
        PlayFabClientAPI.UpdateAvatarUrl(new UpdateAvatarUrlRequest() { ImageUrl = _avatarURL },
        success => { Debug.Log("Avatar Yuklendi"); _isUpdateAvatar = true; },
         error => { Debug.Log("Avatar yuklenmedi"); _isUpdateAvatar = false; });
    }
}