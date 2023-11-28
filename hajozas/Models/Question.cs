using System;
using System.Collections.Generic;

namespace hajozas.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public string? Question1 { get; set; }

    public string? Answer1 { get; set; }

    public string? Answer2 { get; set; }

    public string? Answer3 { get; set; }

    public string? Image { get; set; }

    public byte? CorrectAnswer { get; set; }
}
