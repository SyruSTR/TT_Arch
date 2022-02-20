using TMPro;
using UnityEngine;

//Класс для изменения текста для DLC
public class TextChangingDLC : TextChanging
{

    private PlayerDataDLC _playerDataDlc;
    public override void Awake()
    {
        tmpText = GetComponent<TMP_Text>();
        _playerDataDlc = FindObjectOfType<PlayerDataDLC>();
        _playerDataDlc.ChangeEnergy += ChangeText;
    }
}