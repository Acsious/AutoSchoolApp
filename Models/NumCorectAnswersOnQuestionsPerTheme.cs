using System;
using System.Collections.Generic;

namespace AutoSchoolApp.Models;

public partial class NumCorectAnswersOnQuestionsPerTheme
{
    public string? Тема { get; set; }

    public int? КолВоПравильноРешённыхВопросов { get; set; }
}
