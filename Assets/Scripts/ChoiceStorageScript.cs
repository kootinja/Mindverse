using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Outcome
{
    public static bool GameOutcome { get; set; }
    public static bool ChoseChoice1 { get; set; }
    public static bool ChoseChoice2 { get; set; }
    public static bool ChoseChoice3 { get; set; }
}

public static class Alignment
{
    public static int leastIdeal { get; set; }
    public static int mid { get; set; }
    public static int mostIdeal { get; set; }
}