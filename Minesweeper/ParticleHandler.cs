using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minesweeper
{
    static class ParticleHandler
    {
        public static List<Particle> Particles { get; set; }
        public static int YBound { get; set; }
        private static List<Particle> _removeBin;
        static ParticleHandler()
        {
            _removeBin = new List<Particle>();
            Particles = new List<Particle>();
        }
        public static int GetCount()
        {
            return Particles.Count();
        }
        public static void SetBound(int ybound)
        {
            YBound = ybound;
        }
        public static void Clear()
        {
            _removeBin.Clear();
            Particles.Clear();
        }
        public static bool IsEmpty()
        {
            return !Particles.Any();
        }
        public static void UpdateParticles(float deltaTime)
        {
            foreach(Particle p in Particles)
            {
                p.UpdatePosition(deltaTime);
                if (p.Y >= YBound)
                    _removeBin.Add(p);
            }
            foreach(Particle p in _removeBin)
            {
                Particles.Remove(p);
            }
            _removeBin.Clear();
        }
        public static void Render(Graphics graphics)
        {
            Particles.ForEach(p =>
            {
                p.Render(graphics);
            });
        }
        public static void AddParticle(Particle particle)
        {
            Particles.Add(particle);
        }
    }
    class Particle
    {
        public float X { get; set; } // actual X
        public float Y { get; set; } // actual Y
        public int MineCount { get; set; }
        private int _bound;
        public Particle(float x, float y,int bound, int mineCount)
        {
            X = x;
            Y = y;
            _bound = bound;
            MineCount = mineCount;
        }
        public void UpdatePosition(float deltaTime)
        {
            Y += 200f*deltaTime; //Fall 200px / 1s
        }
        public void Render(Graphics graphics)
        {
            graphics.DrawImage(SpriteHandler.GetCount(MineCount), X, Y, _bound, _bound);
        }
    }
}
