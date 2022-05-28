using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge04.Repository;

namespace Challenge04.Repository
{
    public class OutingRepository
    {

        // Fake Database

        private List<Outing> _outingList = new List<Outing>();

        //private List<Outing> _outingCostsByTypeList = new List<Outing>();

        //private List<Outing> _outingCostsCombinedList = new List<Outing>();

        //CRUD
        // CREATE / READ / UPDATE / DELETE


        // CREATE
        public void AddOutingToList(Outing outing)
        {
            _outingList.Add(outing);
        }

        // public void AddOutingCostToList(decimal outingCost)
        // {
        //     _outingCostsByTypeList.Add(outingCost);
        // }

        //public void AddOutingCostsCombined()
        // {
        //     _outingCostsCombinedList.Add(outingCost);
        // }


        // READ
        public List<Outing> GetAllOutingsFromList()
        {
            return _outingList;
        }


        public decimal OutingCostsByType(string userInputType)
        {
            decimal sum = 0;
            foreach (Outing outing in _outingList)
            {
                if (userInputType.ToUpper() == outing.EventType.ToUpper())
                {
                    sum += outing.CostOfEvent;
                }
            }
            return sum;
        }

        public decimal OutingCostsCombined()
        {
            decimal sum = 0;
            foreach (Outing outing in _outingList)
            {
                sum += outing.CostOfEvent;
            }
            return sum;
        }


        // UPDATE



        // DELETE

        public bool DeleteOutingByTypeAndDate(string userInputType, DateTime userInputDate)
        {
            foreach (Outing outing in _outingList)
            {
                if ((outing.EventType.ToUpper()) == (userInputType.ToUpper()) && (outing.Date == userInputDate))
                {
                    _outingList.Remove(outing);
                    return true;
                }
            }
            return false;
        }



        // SEED DATA

        public void SeedOutingData()
        {
            Outing golf = new Outing(EventType.golf, 10, 06 / 20 / 2020, 75.00m, 750.00m);
            Outing bowling = new Outing(EventType.bowling, 8, 05 / 20 / 2020, 15, 120);
            Outing amusementPark = new Outing(EventType.amusementPark, 20, 04 / 21 / 2020, 150.00m, 3000.00m);
            Outing concert = new Outing(EventType.concert, 15, 06 / 20 / 2020, 50.00m, 250.00m);


            Outing[] outingArr = { golf, bowling, amusementPark, concert };

            foreach (Outing x in outingArr)
            {
                AddOutingToList(x);
            }

            // foreach (Outing x in outingArr)
            // {
            //     AddOutingCostToList(x.CostOfEvent);
            // }

            // foreach (Outing x in outingArr)
            // {

            // }
        }

    }
}