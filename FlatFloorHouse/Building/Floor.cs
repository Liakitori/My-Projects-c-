using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFloorHouse
{
    internal class Floor
    {
        private int NumberOfFlat;
        public Flat[] Flats;
        public Floor(int n)
        {
            NumberOfFlat = n;
            Flats = new Flat[n];
            for (int i = 0; i < NumberOfFlat; i++)
            {
                Flats[i] = new Flat();
            }
        }
        public Floor(Flat[] f)
        {
            NumberOfFlat = f.Length;
            Flats = f;
        }
        public int GetNumberOfFlat()
        {
            return NumberOfFlat;
        }
        public int GetSquareOfFlatsPerFloor()
        {
            int s = 0;
            for (int i = 0; i < NumberOfFlat; i++)
            {
                s += Flats[i].GetSquareOfFlat();
            }
            return s;
        }
        public int GetNumberOfRoomsPerFloor()
        {
            int n = 0;
            for (int i = 0; i < NumberOfFlat; i++)
            {
                n += Flats[i].GetNumberOfRooms();
            }
            return n;
        }
        public Flat[] GetArrayOfFlatsPerFloor()
        {
            return Flats;
        }
        public Flat GetFlat(int i)
        {
            return Flats[i];
        }
        public void SetFlat(int i, Flat f)
        {
            Flats[i] = f;
        }
        public void AddFlat(int i)
        {
            NumberOfFlat++;
            Array.Resize(ref Flats, NumberOfFlat);
            for (int j = (NumberOfFlat - 1);  j > i; j--)
            {
                Flats[j] = Flats[j - 1];
            }
            Flats[i] = new Flat();
        }
        public void AddFlat(int i, Flat f)
        {
            NumberOfFlat++;
            Array.Resize(ref Flats, NumberOfFlat);
            for (int j = (NumberOfFlat - 1); j > i; j--)
            {
                Flats[j] = Flats[j - 1];
            }
            Flats[i] = f;
        }
        public void DeleteFlat(int i)
        {
            for (int j = i; j < NumberOfFlat - 1; j++)
            {
                Flats[j] = Flats[j + 1];
            }
            NumberOfFlat--;
            Array.Resize(ref Flats, NumberOfFlat);
        }
        public int GetBestSquare()
        {
            int BestSquare = 0;
            for(int i = 0; i < NumberOfFlat; i++)
            {
                BestSquare = Math.Max(BestSquare, Flats[i].GetSquareOfFlat());
            }
            return BestSquare;
        }
        public int[] GetSquareMass()
        {
            int[] SquareMass = new int[NumberOfFlat];
            for (int i = 0; i < NumberOfFlat; i++)
            {
                SquareMass[i] = GetFlat(i).GetSquareOfFlat();
            }
            return SquareMass;
        }
    }
}
