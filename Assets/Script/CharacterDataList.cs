using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Charcter
{
    public string name;
    public int hp;
    public int speed;
    public int Power;
}

[CreateAssetMenu(fileName = "NewCharacterDataList", menuName = "ScriptableObjects/CharacterDataList", order = 1)]
public class CharacterDataList : ScriptableObject
{
    public List<Charcter> charcters;
}
