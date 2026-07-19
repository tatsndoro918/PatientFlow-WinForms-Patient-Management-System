using System.IO;
using System.Text.Json;
using WFAPatientTracker.Models;
using WFAPatientTracker.Services;

namespace WFAPatientTracker
{
    public partial class frmMain : Form
    {
        private readonly PatientService patientService = new PatientService();

        private List<Patient> patients = new List<Patient>();

        private Patient? selectedPatient;

        private const string FilePath = "Data/patients.json";

        //Constuctor
        public frmMain()
        {
            InitializeComponent();
        }

        private void RefreshGrid(List<Patient>? patientList = null)
        {
            //Binding
            dgvPatients.DataSource = null;

            dgvPatients.DataSource = patientList ?? patients;
        }

        private void UpdateStatistics()
        {
            lblTotalPatients.Text = $"Total Patients: {patients.Count}";

            lblWaitingPatients.Text =
                $"Waiting: {patients.Count(p => p.Status == "Waiting")}";

            lblInTreatmentPatients.Text =
                $"In Treatment: {patients.Count(p => p.Status == "In Treatment")}";

            lblDischargedPatients.Text =
                $"Discharged: {patients.Count(p => p.Status == "Discharged")}";
        }

        private Patient ReadPatientFromForm()
        {
            return new Patient
            {
                Name = txtPatientName.Text,
                Age = int.Parse(txtAge.Text),
                Condition = txtCondition.Text,
                Priority = cmbPriority.SelectedItem?.ToString() ?? "",
                Status = cmbStatus.SelectedItem?.ToString() ?? "",
                ArrivalTime = DateTime.Now
            };
        }

        //Patient Validation
        private bool ValidatePatientInput()
        {
            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                MessageBox.Show("Please enter the patient's name.");

                txtPatientName.Focus();

                return false;
            }

            if (txtPatientName.Text.Trim().Length < 2)
            {
                MessageBox.Show("Please enter a valid patient name.");

                txtPatientName.Focus();

                return false;
            }


            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");

                txtAge.Focus();

                return false;
            }

            if (age < 0 || age > 120)
            {
                MessageBox.Show("Age must be between 0 and 120.");

                txtAge.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCondition.Text))
            {
                MessageBox.Show("Please enter the patient's condition.");

                txtCondition.Focus();

                return false;
            }

            return true;
        }

        private void LoadPatientIntoForm(Patient patient)
        {
            txtPatientName.Text = patient.Name;

            txtAge.Text = patient.Age.ToString();

            txtCondition.Text = patient.Condition;

            cmbPriority.Text = patient.Priority;

            cmbStatus.Text = patient.Status;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidatePatientInput())
            {
                return;
            }

            Patient patient = ReadPatientFromForm();

            patients.Add(patient);

            patientService.SavePatients(patients);

            RefreshGrid();

            UpdateStatistics();

            ClearForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbPriority.Items.AddRange(new string[]
            {
                "High",
                "Medium",
                "Low"
            });

            cmbStatus.Items.AddRange(new string[]
            {
                "Waiting",
                "In Treatment",
                "Discharged"
            });

            cmbPriority.SelectedIndex = 1;
            cmbStatus.SelectedIndex = 0;

            patients = patientService.LoadPatients();

            RefreshGrid();

            UpdateStatistics();
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedPatient = (Patient)dgvPatients.Rows[e.RowIndex].DataBoundItem;

            LoadPatientIntoForm(selectedPatient);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidatePatientInput())
                return;


            if (selectedPatient == null)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            selectedPatient.Name = txtPatientName.Text;
            selectedPatient.Age = int.Parse(txtAge.Text);
            selectedPatient.Condition = txtCondition.Text;
            selectedPatient.Priority = cmbPriority.Text;
            selectedPatient.Status = cmbStatus.Text;

            patientService.SavePatients(patients);

            RefreshGrid();

            UpdateStatistics();

            ClearForm();
        }

        //Delete Patient Helper
        private void DeletePatient()
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {selectedPatient.Name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                patients.Remove(selectedPatient);

                selectedPatient = null;

                patientService.SavePatients(patients);

                RefreshGrid();

                //UpdateStatistics();

                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }

        //Clear Form Helper
        private void ClearForm()
        {
            txtPatientName.Clear();

            txtAge.Clear();

            txtCondition.Clear();

            cmbPriority.SelectedIndex = 0;

            cmbStatus.SelectedIndex = 0;

            selectedPatient = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filteredPatients = patients.Where(patient =>
                patient.Name.Contains(txtSearch.Text,
                StringComparison.OrdinalIgnoreCase)).
                ToList();

            RefreshGrid(filteredPatients);
        }

    }
}
