﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.Titanfall2.PilotData.Normal_Pilot.PulseBlade
{
    class PulseBlade
    {
        //脉冲刀铁驭
        public string Seek { get; private set; }
        public string Length { get; private set; }
        public string SeekLength { get; private set; }
        public PulseBlade(String PilotPart, int imagecheck)
        {
            String str = PilotPart.Substring(1, PilotPart.Length - 5);
            if (str.Contains("fbody"))
            {
                Part.fbody fb = new Part.fbody(str, imagecheck);
                Seek = fb.Seek;
                Length = fb.Length;
                SeekLength = fb.SeekLength;
            }
            else if (str.Contains("gauntlet"))
            {
                Part.gauntlet ga = new Part.gauntlet(str, imagecheck);
                Seek = ga.Seek;
                Length = ga.Length;
                SeekLength = ga.SeekLength;
            }
            else if (str.Contains("mbody"))
            {
                Part.mbody mb = new Part.mbody(str, imagecheck);
                Seek = mb.Seek;
                Length = mb.Length;
                SeekLength = mb.SeekLength;
            }
            else if (str.Contains("gear"))
            {
                Part.gear g = new Part.gear(str, imagecheck);
                Seek = g.Seek;
                Length = g.Length;
                SeekLength = g.SeekLength;
            }
            else if (str.Contains("jumpkit"))
            {
                Part.jumpkit j = new Part.jumpkit(str, imagecheck);
                Seek = j.Seek;
                Length = j.Length;
                SeekLength = j.SeekLength;
            }
            else if (str.Contains("helmet"))
            {
                Part.helmet he = new Part.helmet(str, imagecheck);
                Seek = he.Seek;
                Length = he.Length;
                SeekLength = he.SeekLength;
            }
            else
            {
                throw new MyException("BUG!"+"\n"+ "In Pilot Part.");
            }
        }
    }
}
