using TMPro;
using UnityEngine;

public class TextChangingDLC : TextChanging
{

    private PlayerDataDLC _playerDataDlc;
    public override void Awake()
    {
        _tmpText = GetComponent<TMP_Text>();
        _playerDataDlc = FindObjectOfType<PlayerDataDLC>();
        _playerDataDlc.ChangeEnergy += ChangeText;
    }
}