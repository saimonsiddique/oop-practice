public class Patient
{
  public string PatientId { get; private set; }
  public string Name { get; set; }
  public DateTime AdmissionDate { get; set; }
  public DateTime DischargeDate { get; set; }
  public string MedicalCondition { get; private set; }

  public Patient(string patientId, string name, DateTime admissionDate, string medicalCondition)
  {
    PatientId = patientId;
    Name = name;
    AdmissionDate = admissionDate;
    MedicalCondition = medicalCondition;
  }

  public void UpdateMedicalCondition(string newCondition)
  {
    MedicalCondition = newCondition;
  }
}