using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoCheatsGD_UI_
{
    public class Source
    {
        public string MainFloder = Settings.Default.MainFloderResalut;
        public List<string> ModeName = new List<string>()
        {
        "bypass.json", //0
        "core.json", //1 
        "global.json",//2
        "player.json",//3
        "variables.json",//4
        "creator.json"//5
        };
    }
}
