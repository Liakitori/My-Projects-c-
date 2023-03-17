using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFloorHouse
{
    internal class House
    {
        private int NumberOfFloors;
        private Floor[] Floors;
        public House(int n, int[] k)
        {
            NumberOfFloors = n;
            Floors = new Floor[NumberOfFloors];
            for (int i = 0; i < NumberOfFloors; i++)
            {
                Floors[i] = new Floor(k[i]);
            }
        }
        public House(Floor[] f)
        {
            NumberOfFloors = f.Length;
            Floors = new Floor[NumberOfFloors];
            for (int i = 0; i < NumberOfFloors; i++)
            {
                Floors[i] = f[i];
            }
        }
        public int GetNumberOfFloors()
        {
            return NumberOfFloors;
        }
        public int GetNumberOfFlatsInTheHouse()
        {
            int n = 0;
            for (int i = 0; i < NumberOfFloors; i++)
            {
                n += Floors[i].GetNumberOfFlat();
            }
            return n;
        }
        public int GetSquareOfFlatsInTheHouse()
        {
            int s = 0;
            for (int i = 0; i < NumberOfFloors; i++)
            {
                for (int j = 0; j < Floors[i].GetNumberOfFlat(); j++)
                {
                    s += Floors[i].GetFlat(j).GetSquareOfFlat();
                }
            }
            return s;
        }
        public int GetNumberOfRoomsInTheHouse()
        {
            int n = 0;
            for (int i = 0; i < NumberOfFloors; i++)
            {
                for (int j = 0; j < Floors[i].GetNumberOfFlat(); j++)
                {
                    n += Floors[i].GetFlat(j).GetNumberOfRooms();
                }
            }
            return n;
        }
        public Floor[] GetArrayOfFloorsInTheHouse()
        {
            return Floors;
        }
        public Floor GetFloor(int i)
        {
            return Floors[i];
        }
        public void SetFloor(int i, Floor f)
        {
            Floors[i] = f;
        }
        public Flat GetFlat(int i)
        {
            int FloorNumber = 0;
            while(i > GetFloor(FloorNumber).GetNumberOfFlat() - 1)
            {
                i -= GetFloor(FloorNumber).GetNumberOfFlat();
                FloorNumber++;
            }
            return GetFloor(FloorNumber).GetFlat(i);
        }
        public void SetFlat(int i, Flat f)
        {
            int FloorNumber = 0;
            while (i > Floors[FloorNumber].GetNumberOfFlat())
            {
                i -= Floors[FloorNumber].GetNumberOfFlat();
                FloorNumber++;
            }
            Floors[FloorNumber].SetFlat(i, f);
        }
        public void AddFlat(int i, Flat f)
        {
            int FloorNumber = 0;
            while (i > Floors[FloorNumber].GetNumberOfFlat())
            {
                i -= Floors[FloorNumber].GetNumberOfFlat();
                FloorNumber++;
            }
            Floors[FloorNumber].AddFlat(i, f);
        }
        public void DeleteFlat(int i)
        {
            int FloorNumber = 0;
            while (i > Floors[FloorNumber].GetNumberOfFlat())
            {
                i -= Floors[FloorNumber].GetNumberOfFlat();
                FloorNumber++;
            }
            Floors[FloorNumber].DeleteFlat(i);
        }
        public int GetBestSquare()
        {
            int BestSquare = 0;
            for (int i = 0; i < NumberOfFloors; i++)
            {
                for (int j = 0; j < Floors[i].GetNumberOfFlat(); j++)
                {
                    BestSquare = Math.Max(BestSquare, Floors[i].GetFlat(j).GetSquareOfFlat());
                }
            }
            return BestSquare;
        }
        public List<int> GetSortMass() 
        {
            List<int> IntermediateSortMass = new(NumberOfFloors);
            List<int> SortMass = new(NumberOfFloors);
            for (int i = 0; i < NumberOfFloors; i++)
            {
                IntermediateSortMass.AddRange(Floors[i].GetSquareMass());
            }
            IntermediateSortMass.Sort();
            for (int i = GetNumberOfFlatsInTheHouse() - 1; i >= 0; i--)
            {
                SortMass.Add(IntermediateSortMass[i]);
            }
            return SortMass;
        }
    }
}
    