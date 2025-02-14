public class Ward
{
  public string WardName { get; set; }
  public int MaxCapacity { get; private set; }
  private readonly List<Patient> patients;

  public Ward(string wardName, int maxCapacity)
  {
    WardName = wardName;
    MaxCapacity = maxCapacity;
    patients = new List<Patient>();
  }

  public void AdmitPatient(Patient patient)
  {
    if (patients.Count >= MaxCapacity)
    {
      throw new InvalidOperationException($"The ward '{WardName}' is full.");
    }
    patients.Add(patient);
  }
  public void DischargePatient(string patientId)
  {
    var patient = patients.FirstOrDefault(p => p.PatientId == patientId);
    if (patient == null)
    {
      throw new InvalidOperationException($"Patient with ID '{patientId}' not found in the ward '{WardName}'.");
    }
    patients.Remove(patient);
  }
  public List<Patient> GetPatientList()
  {
    return patients.ToList();
  }
}