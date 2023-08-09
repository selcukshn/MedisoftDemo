using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedisoftDemo.Models
{
    public class Case : ICloneable
    {
        public Guid Id { get; set; }
        public DateTime time { get; set; }
        public string CaseType { get; set; }
        private int _patientNumber = 1;
        public int PatientNumber
        {
            get => _patientNumber;
            set
            {
                if (value <= 0)
                    _patientNumber = 1;
                else if (value > 100)
                    _patientNumber = 100;
                else
                    _patientNumber = value;
            }
        }
        public string RiskSituation { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighhbour { get; set; }
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PatientInformation { get; set; }
        public string ComplaintDefinition { get; set; }
        public string FirstAid { get; set; }
        public string SelectedAmbulance { get; set; }
        public Guid SelectedTechnician { get; set; }
        public List<string> MediaPaths { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public static List<Case> cases = new List<Case>(){
        new Case{Id=Guid.NewGuid(),time=DateTime.Now,CaseType="Trafik Kazası",City="Adana",District="Seyhan",Neighhbour="19.yüzyıl Mahallesi",Address="Melih Şah okulun sol çaprazı",ComplaintDefinition="bacak gopması",FirstAid="bacak dikiş",PatientInformation="bilinci açık",PatientName="Ali",PatientLastName="Gök",PhoneNumber="+9055555555",SelectedAmbulance="Guid.NewGuid()",SelectedTechnician=Guid.NewGuid()},
         new Case{Id=Guid.NewGuid(),time=DateTime.Now,CaseType="Trafik Kazası",City="Adana",District="Seyhan",Neighhbour="19.yüzyıl Mahallesi",Address="Melih Şah okulun sol çaprazı",ComplaintDefinition="bacak gopması",FirstAid="bacak dikiş",PatientInformation="bilinci açık",PatientName="Gökhan",PatientLastName="Gök",PhoneNumber="+9055555555",SelectedAmbulance="Guid.NewGuid()",SelectedTechnician=Guid.NewGuid()},
        };
    }
}   