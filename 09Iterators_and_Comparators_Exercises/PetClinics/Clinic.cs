using System;
namespace PetClinics
{
    class Clinic
    {
        private string name;
        private Pet[] rooms;

        public Clinic()
        {

        }

        public int Room
        {
            
            set
            {
                rooms = new Pet[value];
            }
        }

        public Pet[] Rooms
        {
            get {return this.rooms; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void Create(string name,int rooms)
        {
            if (rooms%2==0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                this.Name = name;
                this.Room = rooms;

            }
        }

        public bool Add(Pet pet)
        {

            return false;
        }

        public bool Release(string clinicName)
        {
            return false;
        }

        public bool HasEmptyRooms(string clinicName)
        {
            return false;
        }

        public void Print(string clinicName)
        {

        }

        public void Print(string clinicName, string rooms)
        {

        }
    }
}
