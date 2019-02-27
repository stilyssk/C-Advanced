using System.Collections.Generic;

namespace PetClinics
{
    public class ListOfClinic
    {
        private List<Clinic> storeListClinic;

        public ListOfClinic()
        {
            storeListClinic = new List<Clinic>();
        }

        public string newClinic
        {
            set
            {

                storeListClinic.Add(value);
            }
        }
        public int MyProperty { get; set; }
    }
}
