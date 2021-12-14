using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_3
{
    class Appointment
    {
        #region Properties
        private string name;
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        private DateTime actualAppointment;
        public DateTime ActualAppointment
        {
            get { return this.actualAppointment; }
            private set { this.actualAppointment = value; }
        }

        private int appointmentDuration;
        public int AppointmentDuration
        {
            get { return this.appointmentDuration; }
            private set { this.appointmentDuration = value; }
        }
        #endregion

        #region Constructor
        public Appointment(string name, DateTime actualAppointment, int appointmentDuration)
        {
            this.Name = name;
            this.ActualAppointment = actualAppointment;
            this.AppointmentDuration = appointmentDuration;
        }
        #endregion

        #region Methods
        public void ChangeAppointment(TimeSpan newAppointment)
        {
            this.ActualAppointment += newAppointment;
        }

        public static TimeSpan CalculateBiggestTimeSpan(Appointment[] appointemnts)
        {
            for(int i = 0; i < appointemnts.Length - 1; i++)
            {
                for(int j = 0; j < appointemnts.Length - 1 - i; j++)
                {
                    if(appointemnts[j].ActualAppointment > appointemnts[j + 1].ActualAppointment)
                    {
                        Appointment temp = appointemnts[j];
                        appointemnts[j] = appointemnts[j + 1];
                        appointemnts[j + 1] = temp;
                    }
                }
            }

            TimeSpan biggestTimeSpan = appointemnts[1].actualAppointment - appointemnts[0].actualAppointment;

            for(int i = 2; i < appointemnts.Length - 1; i++)
            {
                if (appointemnts[i + 1].actualAppointment - appointemnts[i].actualAppointment > biggestTimeSpan)
                    biggestTimeSpan = appointemnts[i + 1].actualAppointment - appointemnts[i].actualAppointment;
            }

            return biggestTimeSpan;
        }
        #endregion
    }
}
