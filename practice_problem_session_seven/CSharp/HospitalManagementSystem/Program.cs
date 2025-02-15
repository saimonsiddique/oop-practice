// Make a Ward object using Ward.cs and add a few patients to it. Then, display the list of patients in the ward.

Ward ward = new Ward("General", 2);

Patient patient1 = new Patient("P1", "Smith", new DateTime(1990, 1, 1), "Flu");
Patient patient2 = new Patient("P2", "Johnson", new DateTime(1995, 2, 2), "Feaver");
Patient patient3 = new Patient("P3", "Williams", new DateTime(2000, 3, 3), "Cough");

ward.AdmitPatient(patient1);
ward.AdmitPatient(patient2);
// ward.AdmitPatient(patient3);

for (int i = 0; i < ward.GetPatientList().Count; i++)
{
  Console.WriteLine(ward.GetPatientList()[i].Name + " " + ward.GetPatientList()[i].MedicalCondition);
}