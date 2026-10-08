using System;
using System.Collections.Generic;
using System.Text;

namespace PatientApp
{
    public class PatientQueue
    {

        private Node firstPatient;
        private Node lastPatient;

        private int count;

        public void Enqueue(Patient patient)
        {
            Node newNode = new Node(patient);
            if (lastPatient == null) {

                firstPatient = newNode;
                lastPatient = newNode;
            }

            lastPatient.Next = newNode;
            lastPatient = newNode;
        
            count++;

        }
    }
}
