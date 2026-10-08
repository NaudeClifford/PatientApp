
namespace PatientApp
{
    public class Node
    {
        public Patient Data { get; set; }

        public Node Next { get; set; }

        public Node(Patient patient)
        {
            Data = patient;
            Next = null;
        }
    }
}
