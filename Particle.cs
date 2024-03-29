﻿using Liquid;

namespace LiquidSim
{
    class Particle
    {
        public Material mat;
        public float x;
        public float y;
        public float u;
        public float v;
        public int cx;
        public int cy;
        public float[] px = new float[3];
        public float[] py = new float[3];
        public float[] gx = new float[3];
        public float[] gy = new float[3];

        public Particle(Material mat, float x, float y, float u, float v)
        {
            this.mat = mat;
            this.x = x;
            this.y = y;
            this.u = u;
            this.v = v;
        }
    }
}

//EOF

