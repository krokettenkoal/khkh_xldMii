using ee1Dec.C;
using ee1Dec.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ee1Dec.Utils {
    /// <summary>
    /// trac1 binary format reader
    /// </summary>
    class Trac1Reader : TracReader {
        private readonly Stream si;
        private readonly BinaryReader br;

        public Trac1Reader(CustEE ee, CPUState stat) : base(ee, stat) {
            si = stat.fs;
            br = new BinaryReader(si);
        }

        public override bool EOF => si.Position >= si.Length;

        public override void Part1() {
            uint tracpos = br.ReadUInt32();
            Debug.Assert(tracpos == stat.tick, "Tick not found. It means your input is corrupted one.");
            for (int t = 0; t < 32; t++) {
                ee.GPR[t].UD[0] = br.ReadUInt64();
                ee.GPR[t].UD[1] = br.ReadUInt64();
            }
            stat.opc = stat.pc;
            stat.pc = br.ReadUInt32();
        }

        public override void Part2() {
            for (int t = 0; t < 32; t++)
                ee.fpr[t].f = br.ReadSingle();
            for (int t = 0; t < 32; t++)
                ee.fprc[t] = br.ReadUInt32();
            ee.fpracc.f = br.ReadSingle();
            for (int t = 0; t < 32; t++)
                VUt.readVec(ee.VF[t], br);
            for (int t = 0; t < 32; t++)
                VUt.readInt(ee.VI[t], br);
            VUt.readVec(ee.Vacc, br);
            VUt.readfv(ee.Vq, br);
            VUt.readfv(ee.Vp, br);

            memUpdates.Clear();

            while (true) {
                uint x = br.ReadUInt32();
                uint cx = br.ReadUInt32();
                Debug.Assert(0 <= cx && cx <= 33554432, "Memory chunk must be less equal than 32MB");
                if (x == 0 && cx == 0)
                    break;
                if (0 == (x & 0xF0000000)) {
                    int r = si.Read(ee.ram, (int)x, (int)cx);
                    Debug.Assert(r == cx, "EOF reached while reading memory chunk");
                    memUpdates.Add(new MemUpdated { addr = (int)x, size = (int)cx, });
                }
                else {
                    // Skip 0x70000000-0x70003fff scratch pad
                    si.Seek(cx, SeekOrigin.Current);
                }
            }
        }
    }
}
