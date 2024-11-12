using System;

using LockerRental.Workflows;
//using LockerRental.DTOS;
using LockerRental.Actions;

namespace LockerRental.Actions
{
    public class LockerManager
    {
        private LockerContents[] _lockers;
        public LockerManager()
        {
            _lockers = new LockerContents[100];
        }


        public void ListContents()
        {
            for (int i = 0; i < _lockers.Length; i++)
            {
                if (_lockers[i] != null)
                {
                    ConsoleIO.DisplayLockerContents(_lockers[i], i + 1);
                }
            }
        }
       public void ViewLocker(int lockerNumber)
        {

            if (lockerNumber < 1 || lockerNumber > _lockers.Length)
            {
                Console.WriteLine("Invalid locker number.");
                return;
            }

            ConsoleIO.DisplayLockerContents(_lockers[lockerNumber - 1], lockerNumber);




        }

      public void RentLocker(int lockerNumber)
        {
            if (lockerNumber < 1 && lockerNumber > _lockers.Length)
            {
                Console.WriteLine("Invalid locker number.");
                return;
            }

            if (_lockers[lockerNumber - 1] != null)
            {
                Console.WriteLine("Locker is already rented.");
                return;
            }

            string item = ConsoleIO.GetRequiredString("Enter the item you want to store in the locker: ");
            string RenterName = ConsoleIO.GetRequiredString("Enter the renters name: ");
            _lockers[lockerNumber - 1] = new LockerContents { Description = item, renterName = RenterName };

            Console.WriteLine($"Locker {lockerNumber} has been rented for {item} storage.");
        }

      public void EndRental(int lockerNumber)
        {
            if (lockerNumber < 1 || lockerNumber > _lockers.Length)
            {
                Console.WriteLine("Invalid locker number.");
                return;
            }

            if (_lockers[lockerNumber - 1] == null)
            {
                Console.WriteLine("Locker is not currently rented.");
                return;
            }

           if ( _lockers[lockerNumber - 1] != null)
           {
            Console.WriteLine($"Locker {lockerNumber} rental has ended, please take your {_lockers[lockerNumber -1].Description}.");
           }
        }
        

    }
}
