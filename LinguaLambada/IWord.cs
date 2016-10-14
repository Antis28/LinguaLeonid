using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
    public interface IWord
    {
        string EnglishName { get; }
        string RussianName { get; }
        int UsedCounter { get; }
    }
}
