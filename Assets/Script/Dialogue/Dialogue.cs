using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //�ν����� �信 ����
public class Dialogue
{
    public string name;
    [TextArea(3, 10)]
    public string[] sentences;
}
