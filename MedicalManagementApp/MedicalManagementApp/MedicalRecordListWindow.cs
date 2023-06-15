using System;
using System.Collections.Generic;

namespace MedicalManagementApp
{
    internal class MedicalRecordListWindow
    {
        private List<MedicalRecord> medicalRecords;

        public MedicalRecordListWindow(List<MedicalRecord> medicalRecords)
        {
            this.medicalRecords = medicalRecords;
        }

        internal bool? ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}